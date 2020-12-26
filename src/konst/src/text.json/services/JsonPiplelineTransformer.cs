//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    sealed class JsonPiplelineTransformer<T> : JsonConverter<T>
    {
        JsonTransformer<T> Transformer;

        public JsonPiplelineTransformer(JsonTransformer<T> src)
            => Transformer = src;

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => Transformer.Project(reader.GetString());

        public override void Write(Utf8JsonWriter writer, T src, JsonSerializerOptions options)
            => writer.WriteStringValue(Transformer.Project(src));
    }

    sealed class JsonPiplelineTransformer<H,T> : JsonConverter<T>
        where H : struct, IJsonTransformer<T>
    {
        H Transformer;

        public JsonPiplelineTransformer()
            => Transformer = new H();

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => Transformer.Project(reader.GetString());

        public override void Write(Utf8JsonWriter writer, T src, JsonSerializerOptions options)
            => writer.WriteStringValue(Transformer.Project(src));
    }
}