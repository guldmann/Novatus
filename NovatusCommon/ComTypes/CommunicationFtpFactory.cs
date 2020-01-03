namespace NovatusCommon.ComTypes
{
    internal class CommunicationFtpFactory : CommunicationFactory
    {
        public override ICommunication Create() => new CommunicationFtp();
    }
}