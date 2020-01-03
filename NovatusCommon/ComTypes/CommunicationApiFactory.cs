namespace NovatusCommon.ComTypes
{
    public class CommunicationApiFactory : CommunicationFactory
    {
        public override ICommunication Create() => new CommunicationApi();
    }
}