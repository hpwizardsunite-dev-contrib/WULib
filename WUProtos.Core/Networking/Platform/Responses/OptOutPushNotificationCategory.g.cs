// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Platform/Responses/OptOutPushNotificationCategory.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Platform/Responses/OptOutPushNotificationCategory.proto</summary>
  public static partial class OptOutPushNotificationCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Platform/Responses/OptOutPushNotificationCategory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OptOutPushNotificationCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CktXVVByb3Rvcy9OZXR3b3JraW5nL1BsYXRmb3JtL1Jlc3BvbnNlcy9PcHRP",
            "dXRQdXNoTm90aWZpY2F0aW9uQ2F0ZWdvcnkucHJvdG8SJldVUHJvdG9zLk5l",
            "dHdvcmtpbmcuUGxhdGZvcm0uUmVzcG9uc2VzIjwKJk9wdE91dFB1c2hOb3Rp",
            "ZmljYXRpb25DYXRlZ29yeVJlc3BvbnNlEhIKCmNhdGVnb3JpZXMYASADKAli",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Platform.Responses.OptOutPushNotificationCategoryResponse), global::WUProtos.Networking.Platform.Responses.OptOutPushNotificationCategoryResponse.Parser, new[]{ "Categories" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OptOutPushNotificationCategoryResponse : pb::IMessage<OptOutPushNotificationCategoryResponse> {
    private static readonly pb::MessageParser<OptOutPushNotificationCategoryResponse> _parser = new pb::MessageParser<OptOutPushNotificationCategoryResponse>(() => new OptOutPushNotificationCategoryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OptOutPushNotificationCategoryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Platform.Responses.OptOutPushNotificationCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OptOutPushNotificationCategoryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OptOutPushNotificationCategoryResponse(OptOutPushNotificationCategoryResponse other) : this() {
      categories_ = other.categories_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OptOutPushNotificationCategoryResponse Clone() {
      return new OptOutPushNotificationCategoryResponse(this);
    }

    /// <summary>Field number for the "categories" field.</summary>
    public const int CategoriesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_categories_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> categories_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Categories {
      get { return categories_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OptOutPushNotificationCategoryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OptOutPushNotificationCategoryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!categories_.Equals(other.categories_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= categories_.GetHashCode();
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
      categories_.WriteTo(output, _repeated_categories_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += categories_.CalculateSize(_repeated_categories_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OptOutPushNotificationCategoryResponse other) {
      if (other == null) {
        return;
      }
      categories_.Add(other.categories_);
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
          case 10: {
            categories_.AddEntriesFrom(input, _repeated_categories_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
