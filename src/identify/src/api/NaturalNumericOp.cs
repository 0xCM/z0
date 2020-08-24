//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
      using System;
      using System.Runtime.CompilerServices;
      using System.Reflection;

      using static Konst;

      public readonly struct NaturalNumericOp : IHostedApiMethod
      {
          /// <summary>
          /// The operation host to which generic definition and any concrete closures belong
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
          public OpIdentity Id
            => GenericId.Generalize();

          /// <summary>
          /// The generic method definition
          /// </summary>
          public MethodInfo Method {get;}

          /// <summary>
          /// The hosting type uri
          /// </summary>
          public ApiHostUri HostUri
            => Host.Uri;

          [MethodImpl(Inline)]
          public NaturalNumericOp(IApiHost host, GenericOpIdentity id, MethodInfo method, NaturalNumericClosure[] closures)
          {
              Host = host;
              GenericId = id;
              Method = method;
              Closures = closures;
          }
    }
}