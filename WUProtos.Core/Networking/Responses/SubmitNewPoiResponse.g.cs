// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/SubmitNewPoiResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/SubmitNewPoiResponse.proto</summary>
  public static partial class SubmitNewPoiResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/SubmitNewPoiResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SubmitNewPoiResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9TdWJtaXROZXdQb2lS",
            "ZXNwb25zZS5wcm90bxIdV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMi",
            "9gEKFFN1Ym1pdE5ld1BvaVJlc3BvbnNlEkoKBnN0YXR1cxgBIAEoDjI6LldV",
            "UHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlN1Ym1pdE5ld1BvaVJlc3Bv",
            "bnNlLlN0YXR1cxIPCgdtZXNzYWdlGAIgAygJIoABCgZTdGF0dXMSCQoFVU5T",
            "RVQQABILCgdTVUNDRVNTEAESCwoHRkFJTFVSRRACEhIKDklOVEVSTkFMX0VS",
            "Uk9SEAMSHwobVE9PX01BTllfUkVDRU5UX1NVQk1JU1NJT05TEAQSEQoNSU5W",
            "QUxJRF9JTlBVVBAFEgkKBU1JTk9SEAZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.SubmitNewPoiResponse), global::WUProtos.Networking.Responses.SubmitNewPoiResponse.Parser, new[]{ "Status", "Message" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SubmitNewPoiResponse : pb::IMessage<SubmitNewPoiResponse> {
    private static readonly pb::MessageParser<SubmitNewPoiResponse> _parser = new pb::MessageParser<SubmitNewPoiResponse>(() => new SubmitNewPoiResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SubmitNewPoiResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.SubmitNewPoiResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitNewPoiResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitNewPoiResponse(SubmitNewPoiResponse other) : this() {
      status_ = other.status_;
      message_ = other.message_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitNewPoiResponse Clone() {
      return new SubmitNewPoiResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_message_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> message_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Message {
      get { return message_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SubmitNewPoiResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SubmitNewPoiResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if(!message_.Equals(other.message_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      hash ^= message_.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      message_.WriteTo(output, _repeated_message_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += message_.CalculateSize(_repeated_message_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SubmitNewPoiResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      message_.Add(other.message_);
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
            Status = (global::WUProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            message_.AddEntriesFrom(input, _repeated_message_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SubmitNewPoiResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
        [pbr::OriginalName("INTERNAL_ERROR")] InternalError = 3,
        [pbr::OriginalName("TOO_MANY_RECENT_SUBMISSIONS")] TooManyRecentSubmissions = 4,
        [pbr::OriginalName("INVALID_INPUT")] InvalidInput = 5,
        [pbr::OriginalName("MINOR")] Minor = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
