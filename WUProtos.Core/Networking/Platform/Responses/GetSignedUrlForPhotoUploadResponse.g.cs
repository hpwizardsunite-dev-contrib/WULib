// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Platform/Responses/GetSignedUrlForPhotoUploadResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Platform/Responses/GetSignedUrlForPhotoUploadResponse.proto</summary>
  public static partial class GetSignedUrlForPhotoUploadResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Platform/Responses/GetSignedUrlForPhotoUploadResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSignedUrlForPhotoUploadResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck9XVVByb3Rvcy9OZXR3b3JraW5nL1BsYXRmb3JtL1Jlc3BvbnNlcy9HZXRT",
            "aWduZWRVcmxGb3JQaG90b1VwbG9hZFJlc3BvbnNlLnByb3RvEiZXVVByb3Rv",
            "cy5OZXR3b3JraW5nLlBsYXRmb3JtLlJlc3BvbnNlcyLwAQoiR2V0U2lnbmVk",
            "VXJsRm9yUGhvdG9VcGxvYWRSZXNwb25zZRJhCgZzdGF0dXMYASABKA4yUS5X",
            "VVByb3Rvcy5OZXR3b3JraW5nLlBsYXRmb3JtLlJlc3BvbnNlcy5HZXRTaWdu",
            "ZWRVcmxGb3JQaG90b1VwbG9hZFJlc3BvbnNlLlN0YXR1cxISCgpzaWduZWRf",
            "dXJsGAIgASgJEiMKG3N1cHBvcnRpbmdfaW1hZ2Vfc2lnbmVkX3VybBgDIAEo",
            "CSIuCgZTdGF0dXMSCQoFVU5TRVQQABIMCghGQUlMVVJFUxABEgsKB1NVQ0NF",
            "U1MQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Platform.Responses.GetSignedUrlForPhotoUploadResponse), global::WUProtos.Networking.Platform.Responses.GetSignedUrlForPhotoUploadResponse.Parser, new[]{ "Status", "SignedUrl", "SupportingImageSignedUrl" }, null, new[]{ typeof(global::WUProtos.Networking.Platform.Responses.GetSignedUrlForPhotoUploadResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetSignedUrlForPhotoUploadResponse : pb::IMessage<GetSignedUrlForPhotoUploadResponse> {
    private static readonly pb::MessageParser<GetSignedUrlForPhotoUploadResponse> _parser = new pb::MessageParser<GetSignedUrlForPhotoUploadResponse>(() => new GetSignedUrlForPhotoUploadResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetSignedUrlForPhotoUploadResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Platform.Responses.GetSignedUrlForPhotoUploadResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSignedUrlForPhotoUploadResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSignedUrlForPhotoUploadResponse(GetSignedUrlForPhotoUploadResponse other) : this() {
      status_ = other.status_;
      signedUrl_ = other.signedUrl_;
      supportingImageSignedUrl_ = other.supportingImageSignedUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSignedUrlForPhotoUploadResponse Clone() {
      return new GetSignedUrlForPhotoUploadResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Platform.Responses.GetSignedUrlForPhotoUploadResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Platform.Responses.GetSignedUrlForPhotoUploadResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "signed_url" field.</summary>
    public const int SignedUrlFieldNumber = 2;
    private string signedUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SignedUrl {
      get { return signedUrl_; }
      set {
        signedUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "supporting_image_signed_url" field.</summary>
    public const int SupportingImageSignedUrlFieldNumber = 3;
    private string supportingImageSignedUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SupportingImageSignedUrl {
      get { return supportingImageSignedUrl_; }
      set {
        supportingImageSignedUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetSignedUrlForPhotoUploadResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetSignedUrlForPhotoUploadResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (SignedUrl != other.SignedUrl) return false;
      if (SupportingImageSignedUrl != other.SupportingImageSignedUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (SignedUrl.Length != 0) hash ^= SignedUrl.GetHashCode();
      if (SupportingImageSignedUrl.Length != 0) hash ^= SupportingImageSignedUrl.GetHashCode();
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
      if (SignedUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SignedUrl);
      }
      if (SupportingImageSignedUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SupportingImageSignedUrl);
      }
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
      if (SignedUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SignedUrl);
      }
      if (SupportingImageSignedUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SupportingImageSignedUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetSignedUrlForPhotoUploadResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.SignedUrl.Length != 0) {
        SignedUrl = other.SignedUrl;
      }
      if (other.SupportingImageSignedUrl.Length != 0) {
        SupportingImageSignedUrl = other.SupportingImageSignedUrl;
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
            Status = (global::WUProtos.Networking.Platform.Responses.GetSignedUrlForPhotoUploadResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            SignedUrl = input.ReadString();
            break;
          }
          case 26: {
            SupportingImageSignedUrl = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetSignedUrlForPhotoUploadResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("FAILURES")] Failures = 1,
        [pbr::OriginalName("SUCCESS")] Success = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code