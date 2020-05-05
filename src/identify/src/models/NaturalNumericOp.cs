//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
      using System;
      using System.Runtime.CompilerServices;
      using System.Reflection;

      using static Seed;

      public readonly struct NaturalNumericOp : IHostedApiMethod
      {
          /// <summary>
          /// The operation host to which generic definition and any concrete closures belowng
          /// </summary>
          public IApiHost Host {get;}
      
          /// <summary>
          /// The generic operation identity
          /// </summary>
          public GenericOpIdentity GenericId {get;}            

          /// <summary>
          /// The supported closures
          /// </summary>
          public NaturalNumericClosure[] Closures {get;}

          /// <summary>
          /// The generalized identity
          /// </summary>
          public OpIdentity Id => GenericId.Generialize();

          /// <summary>
          /// The generic method definition
          /// </summary>
          public MethodInfo Method {get;}

          /// <summary>
          /// The hosting type uri
          /// </summary>
          public ApiHostUri HostUri => Host.UriPath;

          [MethodImpl(Inline)]
          public static NaturalNumericOp Define(IApiHost host, GenericOpIdentity id, MethodInfo method, NaturalNumericClosure[] closures)            
              => new NaturalNumericOp(host, id,method, closures);

          [MethodImpl(Inline)]
          NaturalNumericOp(IApiHost host, GenericOpIdentity id, MethodInfo method, NaturalNumericClosure[] closures)
          {
              this.Host = host;
              this.GenericId = id;
              this.Method = method;
              this.Closures = closures;
          }        
    }
}