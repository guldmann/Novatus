namespace NovatusCommon.ComTypes
{
    public class CommunicationHttpFactory : CommunicationFactory
    {
        public override ICommunication Create() => new CommunicationHttp();
    }
}