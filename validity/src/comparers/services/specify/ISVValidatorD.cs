namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;
    using static vgeneric;

    using C = OpClass;

    public interface ISVValidatorD<T> : IValidator<T>
        where T : unmanaged
    {   
        void Validate<F>(F f, C.UnaryOp op, W128 w)
            where F : ISVUnaryOp128DApi<T>;   

        void Validate<F>(F f, C.UnaryOp op, W256 w)
            where F : ISVUnaryOp256DApi<T>;

        void Validate<F>(F f, C.BinaryOp op, W128 w)
            where F : ISVBinaryOp128DApi<T>;

        void Validate<F>(F f, C.BinaryOp op, W256 w)
            where F : ISVBinaryOp256DApi<T>;
    }

    public interface ISVValidatorD :  IValidator
    {
        void CheckUnaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128DApi<T>;

        void CheckUnaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256DApi<T>;                

        void CheckShiftScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp128DApi<T>;

        void CheckShiftScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp256DApi<T>;

        void CheckBinaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>;            

        void CheckBinaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>;

        void CheckTernaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128DApi<T>;

        void CheckTernaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256DApi<T>;

        void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>;    
            
        void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>;

        void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
                    where T : unmanaged
                    where F : ISVBinaryOp128Api<T>;

        void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp256Api<T>;
    }
}