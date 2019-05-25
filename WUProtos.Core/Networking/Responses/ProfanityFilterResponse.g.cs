// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/ProfanityFilterResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/ProfanityFilterResponse.proto</summary>
  public static partial class ProfanityFilterResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/ProfanityFilterResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfanityFilterResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9Qcm9mYW5pdHlGaWx0",
            "ZXJSZXNwb25zZS5wcm90bxIdV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25z",
            "ZXMioQEKF1Byb2Zhbml0eUZpbHRlclJlc3BvbnNlEk0KBnN0YXR1cxgBIAMo",
            "DjI9LldVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlByb2Zhbml0eUZp",
            "bHRlclJlc3BvbnNlLlN0YXR1cyI3CgZTdGF0dXMSCQoFVU5TRVQQABILCgdV",
            "TktOT1dOEAESCQoFQUxMT1cQAhIKCgZSRUpFQ1QQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.ProfanityFilterResponse), global::WUProtos.Networking.Responses.ProfanityFilterResponse.Parser, new[]{ "Status" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.ProfanityFilterResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfanityFilterResponse : pb::IMessage<ProfanityFilterResponse> {
    private static readonly pb::MessageParser<ProfanityFilterResponse> _parser = new pb::MessageParser<ProfanityFilterResponse>(() => new ProfanityFilterResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfanityFilterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.ProfanityFilterResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfanityFilterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfanityFilterResponse(ProfanityFilterResponse other) : this() {
      status_ = other.status_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfanityFilterResponse Clone() {
      return new ProfanityFilterResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.ProfanityFilterResponse.Types.Status> _repeated_status_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::WUProtos.Networking.Responses.ProfanityFilterResponse.Types.Status) x);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.ProfanityFilterResponse.Types.Status> status_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.ProfanityFilterResponse.Types.Status>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Responses.ProfanityFilterResponse.Types.Status> Status {
      get { return status_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfanityFilterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfanityFilterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!status_.Equals(other.status_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= status_.GetHashCode();
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
      status_.WriteTo(output, _repeated_status_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += status_.CalculateSize(_repeated_status_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfanityFilterResponse other) {
      if (other == null) {
        return;
      }
      status_.Add(other.status_);
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
          case 10:
          case 8: {
            status_.AddEntriesFrom(input, _repeated_status_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProfanityFilterResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        [pbr::OriginalName("ALLOW")] Allow = 2,
        [pbr::OriginalName("REJECT")] Reject = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
