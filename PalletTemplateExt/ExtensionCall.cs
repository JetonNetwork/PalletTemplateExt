using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Custom;
using System;

namespace SubstrateNetApi.Model.Calls
{
    public class ExtensionCall
    {
        public static GenericExtrinsicCall DoSomething(U32 something)
        {
            return new GenericExtrinsicCall("ConnectFour", "do_something", something);
        }
    }
}
