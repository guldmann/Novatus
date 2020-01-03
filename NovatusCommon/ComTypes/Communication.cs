using System;
using System.Collections.Generic;
using System.Text;
using NovatusCommon.ComTypes;

namespace NovatusCommon.ComTypes
{
    public class Communication
    {
        private readonly Dictionary<ComType, CommunicationFactory> _factories;

        public Communication()
        {

            // TODO: read more here 
            //https://code-maze.com/factory-method/
            // comment out below and revrite foreach statment
            //_factories = new Dictionary<ComType, CommunicationFactory>
            //{
            //    {ComType.HTTP, new CommunicationHttpFactory()}
            //};


            _factories = new Dictionary<ComType, CommunicationFactory>();

            foreach (ComType com in Enum.GetValues(typeof(ComType)))
            {
                var comTypeString = "NovatusCommon.ComTypes.Communication" + Enum.GetName(typeof(ComType), com) + "Factory";
                
                var factory = (CommunicationFactory)Activator.CreateInstance(Type.GetType(comTypeString));

                _factories.Add(com, factory);
            }
        }

        public ICommunication ExecuteCreation(ComType com) => _factories[com].Create();
    }
}
