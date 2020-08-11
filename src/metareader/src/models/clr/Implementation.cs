//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Threading.Tasks;
    using Z0.MS;

    partial struct ClrDataModel
    {
        public struct Implementation
        {
            public readonly struct SymbolServerLocator : IBinaryLocator
            {
                public SymbolServerLocator(string path)
                {

                }

                public string FindBinary(string fileName, int buildTimeStamp, int imageSize, bool checkProperties = true)
                {
                    throw new System.NotImplementedException();
                }

                public Task<string> FindBinaryAsync(string fileName, int buildTimeStamp, int imageSize, bool checkProperties = true)
                {
                    throw new System.NotImplementedException();
                }
            }
        }
    }
}