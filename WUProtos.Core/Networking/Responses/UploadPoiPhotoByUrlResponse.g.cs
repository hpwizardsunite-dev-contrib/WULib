// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/UploadPoiPhotoByUrlResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/UploadPoiPhotoByUrlResponse.proto</summary>
  public static partial class UploadPoiPhotoByUrlResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/UploadPoiPhotoByUrlResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UploadPoiPhotoByUrlResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9VcGxvYWRQb2lQaG90",
            "b0J5VXJsUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzIroDChtVcGxvYWRQb2lQaG90b0J5VXJsUmVzcG9uc2USawoGc3Rh",
            "dHVzGAEgASgOMlsuV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuVXBs",
            "b2FkUG9pUGhvdG9CeVVybFJlc3BvbnNlLlBvcnRhbEN1cmF0aW9uSW1hZ2VS",
            "ZXN1bHQuUmVzdWx0Gq0CChlQb3J0YWxDdXJhdGlvbkltYWdlUmVzdWx0EmsK",
            "BnJlc3VsdBgBIAEoDjJbLldVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "LlVwbG9hZFBvaVBob3RvQnlVcmxSZXNwb25zZS5Qb3J0YWxDdXJhdGlvbklt",
            "YWdlUmVzdWx0LlJlc3VsdCKiAQoGUmVzdWx0EgkKBVVOU0VUEAASCwoHU1VD",
            "Q0VTUxABEhQKEEZFQVRVUkVfRElTQUJMRUQQAhIUChBBTFJFQURZX1VQTE9B",
            "REVEEAMSEwoPSU1BR0VfTk9UX0ZPVU5EEAQSEQoNSU1BR0VfVE9PX0JJRxAF",
            "EhYKEklNQUdFX05PVF9TRVJWQUJMRRAGEhQKEFBPUlRBTF9OT1RfRk9VTkQQ",
            "B2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse), global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Parser, new[]{ "Status" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult), global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Parser, new[]{ "Result" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Types.Result) }, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UploadPoiPhotoByUrlResponse : pb::IMessage<UploadPoiPhotoByUrlResponse> {
    private static readonly pb::MessageParser<UploadPoiPhotoByUrlResponse> _parser = new pb::MessageParser<UploadPoiPhotoByUrlResponse>(() => new UploadPoiPhotoByUrlResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UploadPoiPhotoByUrlResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadPoiPhotoByUrlResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadPoiPhotoByUrlResponse(UploadPoiPhotoByUrlResponse other) : this() {
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadPoiPhotoByUrlResponse Clone() {
      return new UploadPoiPhotoByUrlResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Types.Result status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Types.Result Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UploadPoiPhotoByUrlResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UploadPoiPhotoByUrlResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UploadPoiPhotoByUrlResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            Status = (global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UploadPoiPhotoByUrlResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class PortalCurationImageResult : pb::IMessage<PortalCurationImageResult> {
        private static readonly pb::MessageParser<PortalCurationImageResult> _parser = new pb::MessageParser<PortalCurationImageResult>(() => new PortalCurationImageResult());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PortalCurationImageResult> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PortalCurationImageResult() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PortalCurationImageResult(PortalCurationImageResult other) : this() {
          result_ = other.result_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PortalCurationImageResult Clone() {
          return new PortalCurationImageResult(this);
        }

        /// <summary>Field number for the "result" field.</summary>
        public const int ResultFieldNumber = 1;
        private global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Types.Result result_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Types.Result Result {
          get { return result_; }
          set {
            result_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PortalCurationImageResult);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PortalCurationImageResult other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Result != other.Result) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Result != 0) hash ^= Result.GetHashCode();
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
          if (Result != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Result);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Result != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PortalCurationImageResult other) {
          if (other == null) {
            return;
          }
          if (other.Result != 0) {
            Result = other.Result;
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
                Result = (global::WUProtos.Networking.Responses.UploadPoiPhotoByUrlResponse.Types.PortalCurationImageResult.Types.Result) input.ReadEnum();
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the PortalCurationImageResult message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public enum Result {
            [pbr::OriginalName("UNSET")] Unset = 0,
            [pbr::OriginalName("SUCCESS")] Success = 1,
            [pbr::OriginalName("FEATURE_DISABLED")] FeatureDisabled = 2,
            [pbr::OriginalName("ALREADY_UPLOADED")] AlreadyUploaded = 3,
            [pbr::OriginalName("IMAGE_NOT_FOUND")] ImageNotFound = 4,
            [pbr::OriginalName("IMAGE_TOO_BIG")] ImageTooBig = 5,
            [pbr::OriginalName("IMAGE_NOT_SERVABLE")] ImageNotServable = 6,
            [pbr::OriginalName("PORTAL_NOT_FOUND")] PortalNotFound = 7,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
