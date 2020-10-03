//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    using static ClrMetaCommands;

    public enum ClrMetaCmdKey : byte
    {
        None = 0,
        EmitAssemblyReferences = 1,
    }

    public interface IProjection<H,S,T>
        where H : struct, IProjection<H,S,T>
    {
        S Source {get;}

        T Target {get;}
    }

    public readonly struct Projection<S,T> : IProjection<Projection<S,T>,S,T>
    {
        public S Source {get;}

        public T Target {get;}

        public Projection(S src, T dst)
        {
            Source = src;
            Target = dst;
        }
    }

    public interface IProjector<H,P,S,T>
        where H : struct, IProjector<H,P,S,T>
        where P : struct, IProjection<P,S,T>
    {
        void Project(in P spec);
    }

    public readonly struct ClrMetaCommands
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct EmitAssemblyReferences
        {
            public ClrMetaCmdKey CmdId;

            public FS.FilePath Source;

            public FS.FilePath Target;
        }

        public static void encode(in EmitAssemblyReferences src, out ClrMetaCmdSpec dst)
        {
                dst = default;
        }


        public static void decode(in ClrMetaCmdSpec src, out EmitAssemblyReferences dst)
        {
            dst = default;
        }
    }

    public enum ClrMetaCmdKind : ulong
    {

    }

    public readonly struct ClrMetaCmdSpec
    {
        public ClrMetaCmdKey CmdId {get;}

        public BinaryCode Content {get;}

        [MethodImpl(Inline)]
        public ClrMetaCmdSpec(ClrMetaCmdKey id, BinaryCode content)
        {
            CmdId = id;
            Content = content;
        }
    }

    public readonly struct ClrMetaCmdResult
    {
        public ClrMetaCmdKey CmdId {get;}

        public bool Succeeded {get;}

        public BinaryCode Content {get;}

        [MethodImpl(Inline)]
        public ClrMetaCmdResult(ClrMetaCmdKey id, bool success, BinaryCode content)
        {
            CmdId = id;
            Content = content;
            Succeeded = success;
        }

        public static ClrMetaCmdResult Empty => new ClrMetaCmdResult(ClrMetaCmdKey.None, false, BinaryCode.Empty);
    }

    public sealed class ClrMeta : WfCmdExec<ClrMetaCmdSpec, ClrMetaCmdResult>
    {

        void Execute(in EmitAssemblyReferences cmd)
        {

        }

        protected override ClrMetaCmdResult Execute(IWfShell wf, ClrMetaCmdSpec spec)
        {
            switch(spec.CmdId)
            {
                case ClrMetaCmdKey.EmitAssemblyReferences:
                break;
            }
            return ClrMetaCmdResult.Empty;
        }
    }
}
