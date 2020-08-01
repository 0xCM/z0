//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    /// <summary>
    /// Defines non-generic operations/attributes common to all message types
    /// </summary>
    public interface IMessage : IMessagePacket<string>
    {
        /// <summary>
        /// Uniquely identifies the message within scope of the universe
        /// </summary>
        Guid MessageId { get; }

        /// <summary>
        /// The (untyped) message payload
        /// </summary>
        object Body { get; }

        /// <summary>
        /// Serializes the message, including both attributes and content, to a standardized 
        /// text-based format that conforms to infrastructure expectations
        /// </summary>
        string ToCanonicalForm();

        /// <summary>
        /// Message classifier unique within some well-defined scope
        /// </summary>
        string Type {get;}
    }

    /// <summary>
    /// Defines generic operations/attributes common to all message types
    /// </summary>
    public interface IMessage<out C> : IMessage
    {
        /// <summary>
        /// The (typed) message payload
        /// </summary>
        new C Body { get; }
    }
}