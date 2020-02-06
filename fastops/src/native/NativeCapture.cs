//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class NativeCapture
    {            
        static IMemberCapture Service
        {
            [MethodImpl(Inline)]
            get => default(MemberCapture);
        }

        static void Capture(this IMemberCapture svc, Delegate src, INativeWriter dst)
            => dst.WriteData(svc.Capture(src.Identify(), src, dst.TakeBuffer()));    

        static void Capture(this IMemberCapture svc, MethodInfo src, INativeWriter dst)
            => dst.WriteData(svc.Capture(src.Identify(), src,dst.TakeBuffer()));

        static void Capture(this IMemberCapture svc, OpIdentity id, MethodInfo src, INativeWriter dst)
            => dst.WriteData(svc.Capture(id, src, dst.TakeBuffer()));

        /// <summary>
        /// Captures jitted x86 data for a one-parameter generic method to a caller-supplied buffer
        /// </summary>
        /// <param name="src">The generic method (or definition)</param>
        /// <param name="arg">The type over which to close the method</typeparam>
        /// <param name="dst">The buffer to which native data will be written</param>
        static CapturedMember capture(MethodInfo src, Type[] args, Span<byte> dst)
        {
            var def = src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();
            var m = def.MakeGenericMethod(args);
            return Service.Capture(m.Identify(), m, dst);
        }

        static void capture(MethodInfo src, Type[] args, INativeWriter dst)
        {
            var def = src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();
            var m = def.MakeGenericMethod(args);
            var data = Service.Capture(m.Identify(), m, dst.TakeBuffer());
            dst.WriteData(data);                            
        }

        // static void capture_old(Delegate src, INativeWriter dst)
        //     => dst.WriteData(NativeReader.read(src.Identify(), src, dst.TakeBuffer()));    

        // public static void capture_old(MethodInfo src, INativeWriter dst)
        //     => dst.WriteData(NativeReader.read(src.Identify(), src,dst.TakeBuffer()));

        // static void capture_old(OpIdentity id, MethodInfo src, INativeWriter dst)
        //     => dst.WriteData(NativeReader.read(id, src, dst.TakeBuffer()));

    }
}