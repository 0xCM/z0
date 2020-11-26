//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfShellService
    {
        void Init(IWfShell wf);

        ClrArtifactKey ServiceId {get;}
    }

    /// <summary>
    /// Characterizes a workflow service implementation
    /// </summary>
    /// <typeparam name="H">The reifying type</typeparam>
    [Free]
    public interface IWfShellService<H> : IWfShellService
        where H : IWfShellService<H>, new()
    {
        ClrArtifactKey IWfShellService.ServiceId
            => typeof(H).MetadataToken;
    }
}