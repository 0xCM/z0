//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    partial struct ProjectRunner
    {
        internal class JsonDataSerializer
        {
            private static JsonDataSerializer instance;

            private static JsonSerializer payloadSerializer;

            private static JsonSerializer payloadSerializer2;

            private static JsonSerializer serializer;

            public static JsonDataSerializer Instance => instance ?? (instance = new JsonDataSerializer());

            private JsonDataSerializer()
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    DateParseHandling = DateParseHandling.DateTimeOffset,
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                    TypeNameHandling = TypeNameHandling.None,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                serializer = JsonSerializer.Create();
                payloadSerializer = JsonSerializer.Create(settings);
                payloadSerializer2 = JsonSerializer.Create(settings);
            }

            public Message DeserializeMessage(string rawMessage)
            {
                return Deserialize<Message>(serializer, rawMessage);
            }

            public T DeserializePayload<T>(Message message)
            {
                JsonSerializer jsonSerializer = GetPayloadSerializer(null);
                return Deserialize<T>(jsonSerializer, message.Payload);
            }

            public T Deserialize<T>(string json, int version = 1)
            {
                JsonSerializer jsonSerializer = GetPayloadSerializer(version);
                return Deserialize<T>(jsonSerializer, json);
            }

            public string SerializeMessage(string messageType)
            {
                return Serialize(serializer, new Message
                {
                    MessageType = messageType
                });
            }

            public string SerializePayload(string messageType, object payload)
            {
                return SerializePayload(messageType, payload, 1);
            }

            public string SerializePayload(string messageType, object payload, int version)
            {
                JsonSerializer jsonSerializer = GetPayloadSerializer(version);
                JToken payload2 = JToken.FromObject(payload, jsonSerializer);
                if (version <= 1)
                {
                    return Serialize(serializer, new Message
                    {
                        MessageType = messageType,
                        Payload = payload2
                    });
                }
                return Serialize(serializer, new Message
                {
                    MessageType = messageType,
                    Payload = payload2
                });
            }

            public string Serialize<T>(T data, int version = 1)
            {
                JsonSerializer jsonSerializer = GetPayloadSerializer(version);
                return Serialize(jsonSerializer, data);
            }

            public T Clone<T>(T obj)
            {
                if (obj == null)
                {
                    return default(T);
                }
                string json = Serialize(obj, 2);
                return Deserialize<T>(json, 2);
            }

            private string Serialize<T>(JsonSerializer serializer, T data)
            {
                using StringWriter stringWriter = new StringWriter();
                using JsonTextWriter jsonWriter = new JsonTextWriter(stringWriter);
                serializer.Serialize(jsonWriter, data);
                return stringWriter.ToString();
            }

            private T Deserialize<T>(JsonSerializer serializer, string data)
            {
                using StringReader reader = new StringReader(data);
                using JsonTextReader reader2 = new JsonTextReader(reader);
                return serializer.Deserialize<T>(reader2);
            }

            private T Deserialize<T>(JsonSerializer serializer, JToken jToken)
            {
                return jToken.ToObject<T>(serializer);
            }

            private JsonSerializer GetPayloadSerializer(int? version)
            {
                if (version != 2)
                {
                    return payloadSerializer;
                }
                return payloadSerializer2;
            }
        }
    }
}