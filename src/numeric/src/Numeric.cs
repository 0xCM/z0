namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    [ApiHost("api")]
    public partial class Numeric : IApiHost<Numeric>
    {
        [MethodImpl(Inline)]
        public static NK<T> kind<T>()
            where T : unmanaged
                => default;
    }


    [ApiHost]
    public partial class Scalar : IApiHost<Scalar>
    {

    }

    public static partial class XTend
    {
        
    }
}