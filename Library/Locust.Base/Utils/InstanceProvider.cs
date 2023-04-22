namespace Locust.Base
{
    public class InstanceProvider<TAbstraction, TImplementation>
        where TImplementation : TAbstraction, new()
    {
        private static TAbstraction _instance;
        public static TAbstraction Instance
        {
            get
            {
                TypeHelper.EnsureInitialized<TAbstraction, TImplementation>(ref _instance);

                return _instance;
            }
            set { _instance = value; }
        }
    }
}