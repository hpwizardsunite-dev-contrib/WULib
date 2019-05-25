// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientFtueVideoFromUrl.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientFtueVideoFromUrl.proto</summary>
  public static partial class ClientFtueVideoFromUrlReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientFtueVideoFromUrl.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientFtueVideoFromUrlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRGdHVlVmlkZW9Gcm9tVXJs",
            "LnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudCIsChZDbGllbnRGdHVlVmlk",
            "ZW9Gcm9tVXJsEhIKCnVybF9mb3JtYXQYASABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientFtueVideoFromUrl), global::WUProtos.Data.Client.ClientFtueVideoFromUrl.Parser, new[]{ "UrlFormat" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientFtueVideoFromUrl : pb::IMessage<ClientFtueVideoFromUrl> {
    private static readonly pb::MessageParser<ClientFtueVideoFromUrl> _parser = new pb::MessageParser<ClientFtueVideoFromUrl>(() => new ClientFtueVideoFromUrl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientFtueVideoFromUrl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientFtueVideoFromUrlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFromUrl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFromUrl(ClientFtueVideoFromUrl other) : this() {
      urlFormat_ = other.urlFormat_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFromUrl Clone() {
      return new ClientFtueVideoFromUrl(this);
    }

    /// <summary>Field number for the "url_format" field.</summary>
    public const int UrlFormatFieldNumber = 1;
    private string urlFormat_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UrlFormat {
      get { return urlFormat_; }
      set {
        urlFormat_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientFtueVideoFromUrl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientFtueVideoFromUrl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UrlFormat != other.UrlFormat) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UrlFormat.Length != 0) hash ^= UrlFormat.GetHashCode();
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
      if (UrlFormat.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UrlFormat);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UrlFormat.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UrlFormat);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientFtueVideoFromUrl other) {
      if (other == null) {
        return;
      }
      if (other.UrlFormat.Length != 0) {
        UrlFormat = other.UrlFormat;
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
          case 10: {
            UrlFormat = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
