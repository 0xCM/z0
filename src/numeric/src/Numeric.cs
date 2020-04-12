namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost("api")]
    public partial class Numeric : IApiHost<Numeric>
    {
        
    }

    [ApiHost("as.numeric")]
    public partial class AsNumeric : IApiHost<AsNumeric>
    {                

    }

    [ApiHost]
    public partial class Scalar : IApiHost<Scalar>
    {

    }

    [ApiHost]
    public partial class ScalarPairs : IApiHost<ScalarPairs>
    {

    }

    [ApiHost]
    public partial class BmiMul : IApiHost<BmiMul>
    {

    }

    public static partial class XTend
    {
        
    }
}