// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Token/GoogleToken.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Token {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Token/GoogleToken.proto</summary>
  public static partial class GoogleTokenReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Token/GoogleToken.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GoogleTokenReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVXVVByb3Rvcy9EYXRhL1Rva2VuL0dvb2dsZVRva2VuLnByb3RvEhNXVVBy",
            "b3Rvcy5EYXRhLlRva2VuIh8KC0dvb2dsZVRva2VuEhAKCGlkX3Rva2VuGAEg",
            "ASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Token.GoogleToken), global::WUProtos.Data.Token.GoogleToken.Parser, new[]{ "IdToken" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GoogleToken : pb::IMessage<GoogleToken> {
    private static readonly pb::MessageParser<GoogleToken> _parser = new pb::MessageParser<GoogleToken>(() => new GoogleToken());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GoogleToken> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Token.GoogleTokenReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleToken() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleToken(GoogleToken other) : this() {
      idToken_ = other.idToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GoogleToken Clone() {
      return new GoogleToken(this);
    }

    /// <summary>Field number for the "id_token" field.</summary>
    public const int IdTokenFieldNumber = 1;
    private string idToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IdToken {
      get { return idToken_; }
      set {
        idToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GoogleToken);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GoogleToken other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdToken != other.IdToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdToken.Length != 0) hash ^= IdToken.GetHashCode();
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
      if (IdToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IdToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IdToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IdToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GoogleToken other) {
      if (other == null) {
        return;
      }
      if (other.IdToken.Length != 0) {
        IdToken = other.IdToken;
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
            IdToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
