//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public enum WfServiceRole : uint
    {
        Unspecified = 0,

        CmdRouter,
    }

    [Free]
    public interface IWfService
    {
        void Init(IWfShell wf);

        WfServiceRole Role => default;

        ClrArtifactKey ServiceId {get;}
    }

    /// <summary>
    /// Characterizes a workflow service implementation
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    [Free]
    public interface IWfService<H> : IWfService
        where H : IWfService<H>, new()
    {
        WfServiceRole IWfService.Role
            => WfServiceRole.Unspecified;

        ClrArtifactKey IWfService.ServiceId
            => typeof(H).MetadataToken;
    }
}