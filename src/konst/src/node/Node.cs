//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface INode
    {

    }
    
    public interface INode<T> : INode
    {
        T Content {get;}
    }

    public interface INode<K,T> : INode<T>
        where K : unmanaged
    {
        K Kind {get;}

    }

    public interface INode<I,K,T> : INode<K,T>
        where I : unmanaged
        where K : unmanaged
    {        
        I Identity {get;}    
    }

    public interface INode<C,I,K,T> : INode<I,K,T>
        where K : unmanaged
        where I : unmanaged
    {        
        C Context {get;}                
    }
    
    public readonly struct Node<K,C,I,T> : INode<C,I,K,T>
        where K : unmanaged
        where I : unmanaged
    {
        public T Content {get;}

        public K Kind {get;}
        
        public C Context {get;}
        
        public I Identity {get;}
        
        public Node(T content, K kind, C context, I identity)
        {
            Content = content;
            Kind = kind;
            Identity = identity;
            Context = context;
        }
    }

    public readonly struct FileNode
    {
        
    }

    public enum CoreNodeKind : byte
    {
        None = 0,

        File,
    }   

    public readonly struct WfNode
    {
        public IWfShell Wf {get;}
    }
}