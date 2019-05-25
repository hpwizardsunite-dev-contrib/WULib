// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientPlayerSnapshot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientPlayerSnapshot.proto</summary>
  public static partial class ClientPlayerSnapshotReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientPlayerSnapshot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientPlayerSnapshotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRQbGF5ZXJTbmFwc2hvdC5w",
            "cm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaI1dVUHJvdG9zL0RhdGEvQnVm",
            "Zi9BY3RpdmVCdWZmLnByb3RvIskBChRDbGllbnRQbGF5ZXJTbmFwc2hvdBJP",
            "Cgt2YXVsdF9pdGVtcxgBIAMoCzI6LldVUHJvdG9zLkRhdGEuQ2xpZW50LkNs",
            "aWVudFBsYXllclNuYXBzaG90LlZhdWx0SXRlbXNFbnRyeRItCgVidWZmcxgC",
            "IAMoCzIeLldVUHJvdG9zLkRhdGEuQnVmZi5BY3RpdmVCdWZmGjEKD1ZhdWx0",
            "SXRlbXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAM6AjgBYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Buff.ActiveBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientPlayerSnapshot), global::WUProtos.Data.Client.ClientPlayerSnapshot.Parser, new[]{ "VaultItems", "Buffs" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientPlayerSnapshot : pb::IMessage<ClientPlayerSnapshot> {
    private static readonly pb::MessageParser<ClientPlayerSnapshot> _parser = new pb::MessageParser<ClientPlayerSnapshot>(() => new ClientPlayerSnapshot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientPlayerSnapshot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientPlayerSnapshotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerSnapshot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerSnapshot(ClientPlayerSnapshot other) : this() {
      vaultItems_ = other.vaultItems_.Clone();
      buffs_ = other.buffs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerSnapshot Clone() {
      return new ClientPlayerSnapshot(this);
    }

    /// <summary>Field number for the "vault_items" field.</summary>
    public const int VaultItemsFieldNumber = 1;
    private static readonly pbc::MapField<string, long>.Codec _map_vaultItems_codec
        = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt64(16), 10);
    private readonly pbc::MapField<string, long> vaultItems_ = new pbc::MapField<string, long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, long> VaultItems {
      get { return vaultItems_; }
    }

    /// <summary>Field number for the "buffs" field.</summary>
    public const int BuffsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Buff.ActiveBuff> _repeated_buffs_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Data.Buff.ActiveBuff.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Buff.ActiveBuff> buffs_ = new pbc::RepeatedField<global::WUProtos.Data.Buff.ActiveBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Buff.ActiveBuff> Buffs {
      get { return buffs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientPlayerSnapshot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientPlayerSnapshot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!VaultItems.Equals(other.VaultItems)) return false;
      if(!buffs_.Equals(other.buffs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= VaultItems.GetHashCode();
      hash ^= buffs_.GetHashCode();
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
      vaultItems_.WriteTo(output, _map_vaultItems_codec);
      buffs_.WriteTo(output, _repeated_buffs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += vaultItems_.CalculateSize(_map_vaultItems_codec);
      size += buffs_.CalculateSize(_repeated_buffs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientPlayerSnapshot other) {
      if (other == null) {
        return;
      }
      vaultItems_.Add(other.vaultItems_);
      buffs_.Add(other.buffs_);
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
            vaultItems_.AddEntriesFrom(input, _map_vaultItems_codec);
            break;
          }
          case 18: {
            buffs_.AddEntriesFrom(input, _repeated_buffs_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
