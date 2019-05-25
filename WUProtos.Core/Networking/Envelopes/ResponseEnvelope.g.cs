// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Envelopes/ResponseEnvelope.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Envelopes {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Envelopes/ResponseEnvelope.proto</summary>
  public static partial class ResponseEnvelopeReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Envelopes/ResponseEnvelope.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResponseEnvelopeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRXVVByb3Rvcy9OZXR3b3JraW5nL0VudmVsb3Blcy9SZXNwb25zZUVudmVs",
            "b3BlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLkVudmVsb3BlcxouV1VQ",
            "cm90b3MvTmV0d29ya2luZy9FbnZlbG9wZXMvQXV0aFRpY2tldC5wcm90bxo2",
            "V1VQcm90b3MvTmV0d29ya2luZy9QbGF0Zm9ybS9QbGF0Zm9ybVJlcXVlc3RU",
            "eXBlLnByb3RvIu4EChBSZXNwb25zZUVudmVsb3BlEk8KC3N0YXR1c19jb2Rl",
            "GAEgASgOMjouV1VQcm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMuUmVzcG9u",
            "c2VFbnZlbG9wZS5TdGF0dXNDb2RlEhIKCnJlcXVlc3RfaWQYAiABKAQSDwoH",
            "YXBpX3VybBgDIAEoCRJaChBwbGF0Zm9ybV9yZXR1cm5zGAYgAygLMkAuV1VQ",
            "cm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMuUmVzcG9uc2VFbnZlbG9wZS5Q",
            "bGF0Zm9ybVJlc3BvbnNlEj4KC2F1dGhfdGlja2V0GAcgASgLMikuV1VQcm90",
            "b3MuTmV0d29ya2luZy5FbnZlbG9wZXMuQXV0aFRpY2tldBIPCgdyZXR1cm5z",
            "GGQgAygMEg0KBWVycm9yGGUgASgJGmUKEFBsYXRmb3JtUmVzcG9uc2USPwoE",
            "dHlwZRgBIAEoDjIxLldVUHJvdG9zLk5ldHdvcmtpbmcuUGxhdGZvcm0uUGxh",
            "dGZvcm1SZXF1ZXN0VHlwZRIQCghyZXNwb25zZRgCIAEoDCLAAQoKU3RhdHVz",
            "Q29kZRILCgdVTktOT1dOEAASBgoCT0sQARIaChZPS19SUENfVVJMX0lOX1JF",
            "U1BPTlNFEAISDwoLQkFEX1JFUVVFU1QQAxITCg9JTlZBTElEX1JFUVVFU1QQ",
            "MxIcChhJTlZBTElEX1BMQVRGT1JNX1JFUVVFU1QQNBIMCghSRURJUkVDVBA1",
            "EhcKE1NFU1NJT05fSU5WQUxJREFURUQQZBIWChJJTlZBTElEX0FVVEhfVE9L",
            "RU4QZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Networking.Envelopes.AuthTicketReflection.Descriptor, global::WUProtos.Networking.Platform.PlatformRequestTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Envelopes.ResponseEnvelope), global::WUProtos.Networking.Envelopes.ResponseEnvelope.Parser, new[]{ "StatusCode", "RequestId", "ApiUrl", "PlatformReturns", "AuthTicket", "Returns", "Error" }, null, new[]{ typeof(global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.StatusCode) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.PlatformResponse), global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.PlatformResponse.Parser, new[]{ "Type", "Response" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ResponseEnvelope : pb::IMessage<ResponseEnvelope> {
    private static readonly pb::MessageParser<ResponseEnvelope> _parser = new pb::MessageParser<ResponseEnvelope>(() => new ResponseEnvelope());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResponseEnvelope> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Envelopes.ResponseEnvelopeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseEnvelope() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseEnvelope(ResponseEnvelope other) : this() {
      statusCode_ = other.statusCode_;
      requestId_ = other.requestId_;
      apiUrl_ = other.apiUrl_;
      platformReturns_ = other.platformReturns_.Clone();
      authTicket_ = other.authTicket_ != null ? other.authTicket_.Clone() : null;
      returns_ = other.returns_.Clone();
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseEnvelope Clone() {
      return new ResponseEnvelope(this);
    }

    /// <summary>Field number for the "status_code" field.</summary>
    public const int StatusCodeFieldNumber = 1;
    private global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.StatusCode statusCode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.StatusCode StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 2;
    private ulong requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "api_url" field.</summary>
    public const int ApiUrlFieldNumber = 3;
    private string apiUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApiUrl {
      get { return apiUrl_; }
      set {
        apiUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "platform_returns" field.</summary>
    public const int PlatformReturnsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.PlatformResponse> _repeated_platformReturns_codec
        = pb::FieldCodec.ForMessage(50, global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.PlatformResponse.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.PlatformResponse> platformReturns_ = new pbc::RepeatedField<global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.PlatformResponse>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.PlatformResponse> PlatformReturns {
      get { return platformReturns_; }
    }

    /// <summary>Field number for the "auth_ticket" field.</summary>
    public const int AuthTicketFieldNumber = 7;
    private global::WUProtos.Networking.Envelopes.AuthTicket authTicket_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Envelopes.AuthTicket AuthTicket {
      get { return authTicket_; }
      set {
        authTicket_ = value;
      }
    }

    /// <summary>Field number for the "returns" field.</summary>
    public const int ReturnsFieldNumber = 100;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_returns_codec
        = pb::FieldCodec.ForBytes(802);
    private readonly pbc::RepeatedField<pb::ByteString> returns_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> Returns {
      get { return returns_; }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 101;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResponseEnvelope);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResponseEnvelope other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatusCode != other.StatusCode) return false;
      if (RequestId != other.RequestId) return false;
      if (ApiUrl != other.ApiUrl) return false;
      if(!platformReturns_.Equals(other.platformReturns_)) return false;
      if (!object.Equals(AuthTicket, other.AuthTicket)) return false;
      if(!returns_.Equals(other.returns_)) return false;
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
      if (ApiUrl.Length != 0) hash ^= ApiUrl.GetHashCode();
      hash ^= platformReturns_.GetHashCode();
      if (authTicket_ != null) hash ^= AuthTicket.GetHashCode();
      hash ^= returns_.GetHashCode();
      if (Error.Length != 0) hash ^= Error.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) StatusCode);
      }
      if (RequestId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(RequestId);
      }
      if (ApiUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ApiUrl);
      }
      platformReturns_.WriteTo(output, _repeated_platformReturns_codec);
      if (authTicket_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AuthTicket);
      }
      returns_.WriteTo(output, _repeated_returns_codec);
      if (Error.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StatusCode);
      }
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      if (ApiUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiUrl);
      }
      size += platformReturns_.CalculateSize(_repeated_platformReturns_codec);
      if (authTicket_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AuthTicket);
      }
      size += returns_.CalculateSize(_repeated_returns_codec);
      if (Error.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResponseEnvelope other) {
      if (other == null) {
        return;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
      }
      if (other.ApiUrl.Length != 0) {
        ApiUrl = other.ApiUrl;
      }
      platformReturns_.Add(other.platformReturns_);
      if (other.authTicket_ != null) {
        if (authTicket_ == null) {
          AuthTicket = new global::WUProtos.Networking.Envelopes.AuthTicket();
        }
        AuthTicket.MergeFrom(other.AuthTicket);
      }
      returns_.Add(other.returns_);
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            StatusCode = (global::WUProtos.Networking.Envelopes.ResponseEnvelope.Types.StatusCode) input.ReadEnum();
            break;
          }
          case 16: {
            RequestId = input.ReadUInt64();
            break;
          }
          case 26: {
            ApiUrl = input.ReadString();
            break;
          }
          case 50: {
            platformReturns_.AddEntriesFrom(input, _repeated_platformReturns_codec);
            break;
          }
          case 58: {
            if (authTicket_ == null) {
              AuthTicket = new global::WUProtos.Networking.Envelopes.AuthTicket();
            }
            input.ReadMessage(AuthTicket);
            break;
          }
          case 802: {
            returns_.AddEntriesFrom(input, _repeated_returns_codec);
            break;
          }
          case 810: {
            Error = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ResponseEnvelope message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum StatusCode {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        /// <summary>
        /// valid response with no api url
        /// </summary>
        [pbr::OriginalName("OK")] Ok = 1,
        /// <summary>
        /// the response envelope has api_url set and this response is valid
        /// </summary>
        [pbr::OriginalName("OK_RPC_URL_IN_RESPONSE")] OkRpcUrlInResponse = 2,
        /// <summary>
        /// bad request
        /// </summary>
        [pbr::OriginalName("BAD_REQUEST")] BadRequest = 3,
        /// <summary>
        /// using unimplemented request or corrupt request
        /// </summary>
        [pbr::OriginalName("INVALID_REQUEST")] InvalidRequest = 51,
        /// <summary>
        /// invalid platform request or corrupt platform request
        /// </summary>
        [pbr::OriginalName("INVALID_PLATFORM_REQUEST")] InvalidPlatformRequest = 52,
        /// <summary>
        /// a new rpc endpoint is available and you should redirect to there
        /// </summary>
        [pbr::OriginalName("REDIRECT")] Redirect = 53,
        /// <summary>
        /// occurs when you send blank authinfo, or sending nonsense timings (ie LocationFix.timestampSnapshot == Signature.timestampSinceStart)
        /// </summary>
        [pbr::OriginalName("SESSION_INVALIDATED")] SessionInvalidated = 100,
        /// <summary>
        /// occurs when the login token is invalid
        /// </summary>
        [pbr::OriginalName("INVALID_AUTH_TOKEN")] InvalidAuthToken = 102,
      }

      public sealed partial class PlatformResponse : pb::IMessage<PlatformResponse> {
        private static readonly pb::MessageParser<PlatformResponse> _parser = new pb::MessageParser<PlatformResponse>(() => new PlatformResponse());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PlatformResponse> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Envelopes.ResponseEnvelope.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlatformResponse() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlatformResponse(PlatformResponse other) : this() {
          type_ = other.type_;
          response_ = other.response_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlatformResponse Clone() {
          return new PlatformResponse(this);
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 1;
        private global::WUProtos.Networking.Platform.PlatformRequestType type_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::WUProtos.Networking.Platform.PlatformRequestType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        /// <summary>Field number for the "response" field.</summary>
        public const int ResponseFieldNumber = 2;
        private pb::ByteString response_ = pb::ByteString.Empty;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString Response {
          get { return response_; }
          set {
            response_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PlatformResponse);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PlatformResponse other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Type != other.Type) return false;
          if (Response != other.Response) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Type != 0) hash ^= Type.GetHashCode();
          if (Response.Length != 0) hash ^= Response.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Type != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Type);
          }
          if (Response.Length != 0) {
            output.WriteRawTag(18);
            output.WriteBytes(Response);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Type != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (Response.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(Response);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PlatformResponse other) {
          if (other == null) {
            return;
          }
          if (other.Type != 0) {
            Type = other.Type;
          }
          if (other.Response.Length != 0) {
            Response = other.Response;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                Type = (global::WUProtos.Networking.Platform.PlatformRequestType) input.ReadEnum();
                break;
              }
              case 18: {
                Response = input.ReadBytes();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
