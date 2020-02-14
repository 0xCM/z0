//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static RootShare;

    public interface IArtifactModel
    {
        string Name {get;}
    }

    public interface IArtifactModel<T> : IArtifactModel
    {

    }

    public interface IClrArtifact : IArtifactModel
    {        
    
    }

    public interface IClrArtifact<T> : IClrArtifact, IArtifactModel<T>
    {
        T Subject {get;}    
    }

    
    public interface IClrTypeModel : IClrArtifact<Type>
    {
        string IArtifactModel.Name
            => Subject.Name;

        bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Subject == typeof(void);
        }
    }

    public interface IClrTypeModel<T> : IClrTypeModel
        where T : struct, IClrTypeModel<T>
    {

    }

    public interface IGenericArtifact<T> : IClrArtifact
    {        

        GenericKind Kind {get;}
    }
}