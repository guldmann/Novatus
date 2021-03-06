﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace LogSystem
{
	public class Log
	{
		private static string Path { get; set; }
		static string LogName { get; set; }

		public delegate void EventStringHandler(Log log, EventStrign e);
		public event EventStringHandler AddStringEvent;
		public event AddingNewEventHandler AddEvent;
		static List<string> MessageList = new List<string>();

		public Log(string path = "LOG\\", string logName = null)
		{
			if (string.IsNullOrEmpty(Path))
			{
				Path = path;

				if (!Directory.Exists(Path))
				{
					Directory.CreateDirectory(Path);
				}
			}

			if (string.IsNullOrEmpty(LogName))
			{
				if (logName != null)
				{
					LogName = logName;
				}
				else
				{
					LogName = "Log_" + DateTime.Now.ToString().Replace('-', '_').Replace(':', '.').Replace('/', '_') + ".txt ";
				}
			}
		}

		~Log()
		{
			if (MessageList.Count >= 1)
			{
				Dump();
			}
		}

	   public void Add(string message, [CallerMemberName] string membername = "")
		{
			
			string logString = DateTime.Now + "\t" + membername + "\t" + message;
			MessageList.Add(logString);
			if (AddStringEvent != null)
			{
				EventStrign eStr = new EventStrign();
				eStr.evetString = logString;
				AddStringEvent(this, eStr);
			}
		}
		
		public void Add(string[] message, [CallerMemberName] string membername = "")
		{
			foreach (var msg in message)
			{
				string logstring = DateTime.Now + "\t" + membername + "\t" + msg;
				MessageList.Add(logstring);
				if (AddStringEvent != null)
				{
					EventStrign eStr= new EventStrign();
					eStr.evetString = logstring;
					AddStringEvent(this, eStr);
				}
			}
			
		}

		private void OnAdd(AddingNewEventArgs e)
		{
			if (AddEvent != null)
			{
				AddEvent(this, e);
			}
		}

		public void AddRange(List<string> logRange)
		{
			MessageList.AddRange(logRange);
		}
		public void Dump([CallerMemberName] string membername = "")
		{
			Write(MessageList, membername);
			MessageList = new List<string>();
		}

		public void Write(string message, [CallerMemberName] string membername = "")
		{
			using (StreamWriter sw = File.AppendText(Path + LogName))
			{
				string logString = DateTime.Now + "\t" + membername + "\t" + message;
				sw.WriteLine(logString);
				OnAdd(new AddingNewEventArgs(logString));
			}
		}

		public void Write(List<string> messages, [CallerMemberName] string membername = "")
		{
			try
			{
				File.AppendAllLines(Path + LogName, messages);
			}
			catch (Exception)
			{
				//Ignore
			}

		}

		public void Write(string[] messages, [CallerMemberName] string membername = "")
		{
			File.AppendAllLines(Path + LogName, messages);
		}

		public void ObjectDump(Object obj)
		{
			Type myType = obj.GetType();

			IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
			foreach (var prop in props)
			{
				//TODO: IF propType is list<string>  dump list to log 
				//TODO: if list of object ? do recursive dump of values 

				object propertyValue = prop.GetValue(obj, null);
				object propType = prop.PropertyType;
				object propName = prop.Name;
				Write(propName + " (" + propType + ")" + " = " + propertyValue);
			}
		}

		public List<string> GetLog()
		{
			return MessageList;
		}

		/*
		public void Write(MemoryStream messageMemoryStream)
		{
			FileStream fs = new FileStream(Path + LogName, FileMode.Append);
			messageMemoryStream.CopyTo(fs);
		}
		*/
	}

	public class EventStrign : EventArgs
	{
		public string evetString { get; set; }
	}
}
