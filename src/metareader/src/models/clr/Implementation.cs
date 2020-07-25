//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Threading.Tasks;

    partial struct ClrDataModel
    {
        readonly struct Implementation
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