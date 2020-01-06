namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    using static zfunc;

    public class AsmRdRand
    {        
        /// <summary>
        /// Finds the first method declared by a type that matches a specified name
        /// and returns a pointer to the method definition
        /// </summary>
        /// <param name="name">The method name</param>
        /// <typeparam name="T">The declaring type</typeparam>
        [MethodImpl(Inline)]
        public static IntPtr methodPtr<T>(string name, T t = default)
            => method<T>(name).MethodHandle.GetFunctionPointer();

        static AsmRdRand()
        {
            var rdrand = new byte[] 
            { 
                0x0f, 0xc7, 0xf0,  // rdrand eax
                0x0f, 0x92, 0x01,  // setc byte ptr [rcx]                           
                0xc3               // ret
            };            
            
            Marshal.Copy(rdrand, 0, methodPtr<AsmRdRand>(nameof(RandNative)), rdrand.Length);
        
            
            var code = AsmCode.Load(rdrand, moniker<uint>("rdrand"));
            var emitter = CreateEmitter<uint>(code);
            emitter();

        }

        /// <summary>
        /// Creates a value-producing operator that accepts no arguments
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <typeparam name="T">The emission type</typeparam>
        static Emitter<T> CreateEmitter<T>(AsmCode code)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{};
            var returnType = t;
            var method = new DynamicMethod(code.Name, returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);            
            return (Emitter<T>)method.CreateDelegate(typeof(Emitter<T>));
        }


        [MethodImpl(Inline)]
        public static uint Rand()
            => RandNative();


        [MethodImpl(NotInline)]
        static uint RandNative()
        {
            var data = new byte[6];
            return 0;
        }



    }
}