// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Combat/CombatResults.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Combat {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Combat/CombatResults.proto</summary>
  public static partial class CombatResultsReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Combat/CombatResults.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CombatResultsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihXVVByb3Rvcy9EYXRhL0NvbWJhdC9Db21iYXRSZXN1bHRzLnByb3RvEhRX",
            "VVByb3Rvcy5EYXRhLkNvbWJhdCLHBwoNQ29tYmF0UmVzdWx0cxIbChNjdXJy",
            "ZW50X3N0YXRlX2luZGV4GAEgASgDEhQKDGN1cnJlbnRfY3JpdBgCIAEoCBIY",
            "ChBuZXh0X3N0YXRlX2luZGV4GAMgASgDEhEKCW5leHRfY3JpdBgEIAEoCBIY",
            "ChBocF9jdXJyZW50X2VuZW15GAUgASgDEhkKEWhwX2N1cnJlbnRfcGxheWVy",
            "GAYgASgDEg0KBWxldmVsGAcgASgFEhQKDGVuZW15X2RvZGdlcxgIIAEoCBIV",
            "Cg1wbGF5ZXJfZG9kZ2VzGAkgASgIElsKGHRlbXBfY2xpZW50X3N0YXRzX2hl",
            "bHBlchhkIAEoCzI5LldVUHJvdG9zLkRhdGEuQ29tYmF0LkNvbWJhdFJlc3Vs",
            "dHMuVGVtcENsaWVudFN0YXRzSGVscGVyGocFChVUZW1wQ2xpZW50U3RhdHNI",
            "ZWxwZXISbQoTcGxheWVyX2FjdGl2ZV9zdGF0cxgBIAMoCzJQLldVUHJvdG9z",
            "LkRhdGEuQ29tYmF0LkNvbWJhdFJlc3VsdHMuVGVtcENsaWVudFN0YXRzSGVs",
            "cGVyLlBsYXllckFjdGl2ZVN0YXRzRW50cnkSawoSZW5lbXlfYWN0aXZlX3N0",
            "YXRzGAIgAygLMk8uV1VQcm90b3MuRGF0YS5Db21iYXQuQ29tYmF0UmVzdWx0",
            "cy5UZW1wQ2xpZW50U3RhdHNIZWxwZXIuRW5lbXlBY3RpdmVTdGF0c0VudHJ5",
            "EhQKDGhwX21heF9lbmVteRgDIAEoAxIeChZlbmVteV9kYW1hZ2VfdW5ibG9j",
            "a2VkGAQgAygDEhwKFGVuZW15X2RhbWFnZV9ibG9ja2VkGAUgAygDEhUKDWhw",
            "X21heF9wbGF5ZXIYBiABKAMSdgoYcGxheWVyX2RhbWFnZV9wZXJfZW5lcmd5",
            "GAcgAygLMlQuV1VQcm90b3MuRGF0YS5Db21iYXQuQ29tYmF0UmVzdWx0cy5U",
            "ZW1wQ2xpZW50U3RhdHNIZWxwZXIuUGxheWVyRGFtYWdlUGVyRW5lcmd5RW50",
            "cnkaOAoWUGxheWVyQWN0aXZlU3RhdHNFbnRyeRILCgNrZXkYASABKAkSDQoF",
            "dmFsdWUYAiABKAM6AjgBGjcKFUVuZW15QWN0aXZlU3RhdHNFbnRyeRILCgNr",
            "ZXkYASABKAkSDQoFdmFsdWUYAiABKAM6AjgBGjwKGlBsYXllckRhbWFnZVBl",
            "ckVuZXJneUVudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoAzoCOAFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Combat.CombatResults), global::WUProtos.Data.Combat.CombatResults.Parser, new[]{ "CurrentStateIndex", "CurrentCrit", "NextStateIndex", "NextCrit", "HpCurrentEnemy", "HpCurrentPlayer", "Level", "EnemyDodges", "PlayerDodges", "TempClientStatsHelper" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Combat.CombatResults.Types.TempClientStatsHelper), global::WUProtos.Data.Combat.CombatResults.Types.TempClientStatsHelper.Parser, new[]{ "PlayerActiveStats", "EnemyActiveStats", "HpMaxEnemy", "EnemyDamageUnblocked", "EnemyDamageBlocked", "HpMaxPlayer", "PlayerDamagePerEnergy" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, })})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CombatResults : pb::IMessage<CombatResults> {
    private static readonly pb::MessageParser<CombatResults> _parser = new pb::MessageParser<CombatResults>(() => new CombatResults());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CombatResults> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Combat.CombatResultsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatResults() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatResults(CombatResults other) : this() {
      currentStateIndex_ = other.currentStateIndex_;
      currentCrit_ = other.currentCrit_;
      nextStateIndex_ = other.nextStateIndex_;
      nextCrit_ = other.nextCrit_;
      hpCurrentEnemy_ = other.hpCurrentEnemy_;
      hpCurrentPlayer_ = other.hpCurrentPlayer_;
      level_ = other.level_;
      enemyDodges_ = other.enemyDodges_;
      playerDodges_ = other.playerDodges_;
      tempClientStatsHelper_ = other.tempClientStatsHelper_ != null ? other.tempClientStatsHelper_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatResults Clone() {
      return new CombatResults(this);
    }

    /// <summary>Field number for the "current_state_index" field.</summary>
    public const int CurrentStateIndexFieldNumber = 1;
    private long currentStateIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CurrentStateIndex {
      get { return currentStateIndex_; }
      set {
        currentStateIndex_ = value;
      }
    }

    /// <summary>Field number for the "current_crit" field.</summary>
    public const int CurrentCritFieldNumber = 2;
    private bool currentCrit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CurrentCrit {
      get { return currentCrit_; }
      set {
        currentCrit_ = value;
      }
    }

    /// <summary>Field number for the "next_state_index" field.</summary>
    public const int NextStateIndexFieldNumber = 3;
    private long nextStateIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NextStateIndex {
      get { return nextStateIndex_; }
      set {
        nextStateIndex_ = value;
      }
    }

    /// <summary>Field number for the "next_crit" field.</summary>
    public const int NextCritFieldNumber = 4;
    private bool nextCrit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NextCrit {
      get { return nextCrit_; }
      set {
        nextCrit_ = value;
      }
    }

    /// <summary>Field number for the "hp_current_enemy" field.</summary>
    public const int HpCurrentEnemyFieldNumber = 5;
    private long hpCurrentEnemy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long HpCurrentEnemy {
      get { return hpCurrentEnemy_; }
      set {
        hpCurrentEnemy_ = value;
      }
    }

    /// <summary>Field number for the "hp_current_player" field.</summary>
    public const int HpCurrentPlayerFieldNumber = 6;
    private long hpCurrentPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long HpCurrentPlayer {
      get { return hpCurrentPlayer_; }
      set {
        hpCurrentPlayer_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 7;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "enemy_dodges" field.</summary>
    public const int EnemyDodgesFieldNumber = 8;
    private bool enemyDodges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnemyDodges {
      get { return enemyDodges_; }
      set {
        enemyDodges_ = value;
      }
    }

    /// <summary>Field number for the "player_dodges" field.</summary>
    public const int PlayerDodgesFieldNumber = 9;
    private bool playerDodges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PlayerDodges {
      get { return playerDodges_; }
      set {
        playerDodges_ = value;
      }
    }

    /// <summary>Field number for the "temp_client_stats_helper" field.</summary>
    public const int TempClientStatsHelperFieldNumber = 100;
    private global::WUProtos.Data.Combat.CombatResults.Types.TempClientStatsHelper tempClientStatsHelper_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Combat.CombatResults.Types.TempClientStatsHelper TempClientStatsHelper {
      get { return tempClientStatsHelper_; }
      set {
        tempClientStatsHelper_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CombatResults);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CombatResults other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentStateIndex != other.CurrentStateIndex) return false;
      if (CurrentCrit != other.CurrentCrit) return false;
      if (NextStateIndex != other.NextStateIndex) return false;
      if (NextCrit != other.NextCrit) return false;
      if (HpCurrentEnemy != other.HpCurrentEnemy) return false;
      if (HpCurrentPlayer != other.HpCurrentPlayer) return false;
      if (Level != other.Level) return false;
      if (EnemyDodges != other.EnemyDodges) return false;
      if (PlayerDodges != other.PlayerDodges) return false;
      if (!object.Equals(TempClientStatsHelper, other.TempClientStatsHelper)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentStateIndex != 0L) hash ^= CurrentStateIndex.GetHashCode();
      if (CurrentCrit != false) hash ^= CurrentCrit.GetHashCode();
      if (NextStateIndex != 0L) hash ^= NextStateIndex.GetHashCode();
      if (NextCrit != false) hash ^= NextCrit.GetHashCode();
      if (HpCurrentEnemy != 0L) hash ^= HpCurrentEnemy.GetHashCode();
      if (HpCurrentPlayer != 0L) hash ^= HpCurrentPlayer.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (EnemyDodges != false) hash ^= EnemyDodges.GetHashCode();
      if (PlayerDodges != false) hash ^= PlayerDodges.GetHashCode();
      if (tempClientStatsHelper_ != null) hash ^= TempClientStatsHelper.GetHashCode();
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
      if (CurrentStateIndex != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CurrentStateIndex);
      }
      if (CurrentCrit != false) {
        output.WriteRawTag(16);
        output.WriteBool(CurrentCrit);
      }
      if (NextStateIndex != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(NextStateIndex);
      }
      if (NextCrit != false) {
        output.WriteRawTag(32);
        output.WriteBool(NextCrit);
      }
      if (HpCurrentEnemy != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(HpCurrentEnemy);
      }
      if (HpCurrentPlayer != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(HpCurrentPlayer);
      }
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Level);
      }
      if (EnemyDodges != false) {
        output.WriteRawTag(64);
        output.WriteBool(EnemyDodges);
      }
      if (PlayerDodges != false) {
        output.WriteRawTag(72);
        output.WriteBool(PlayerDodges);
      }
      if (tempClientStatsHelper_ != null) {
        output.WriteRawTag(162, 6);
        output.WriteMessage(TempClientStatsHelper);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentStateIndex != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentStateIndex);
      }
      if (CurrentCrit != false) {
        size += 1 + 1;
      }
      if (NextStateIndex != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextStateIndex);
      }
      if (NextCrit != false) {
        size += 1 + 1;
      }
      if (HpCurrentEnemy != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HpCurrentEnemy);
      }
      if (HpCurrentPlayer != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HpCurrentPlayer);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (EnemyDodges != false) {
        size += 1 + 1;
      }
      if (PlayerDodges != false) {
        size += 1 + 1;
      }
      if (tempClientStatsHelper_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TempClientStatsHelper);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CombatResults other) {
      if (other == null) {
        return;
      }
      if (other.CurrentStateIndex != 0L) {
        CurrentStateIndex = other.CurrentStateIndex;
      }
      if (other.CurrentCrit != false) {
        CurrentCrit = other.CurrentCrit;
      }
      if (other.NextStateIndex != 0L) {
        NextStateIndex = other.NextStateIndex;
      }
      if (other.NextCrit != false) {
        NextCrit = other.NextCrit;
      }
      if (other.HpCurrentEnemy != 0L) {
        HpCurrentEnemy = other.HpCurrentEnemy;
      }
      if (other.HpCurrentPlayer != 0L) {
        HpCurrentPlayer = other.HpCurrentPlayer;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.EnemyDodges != false) {
        EnemyDodges = other.EnemyDodges;
      }
      if (other.PlayerDodges != false) {
        PlayerDodges = other.PlayerDodges;
      }
      if (other.tempClientStatsHelper_ != null) {
        if (tempClientStatsHelper_ == null) {
          TempClientStatsHelper = new global::WUProtos.Data.Combat.CombatResults.Types.TempClientStatsHelper();
        }
        TempClientStatsHelper.MergeFrom(other.TempClientStatsHelper);
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
            CurrentStateIndex = input.ReadInt64();
            break;
          }
          case 16: {
            CurrentCrit = input.ReadBool();
            break;
          }
          case 24: {
            NextStateIndex = input.ReadInt64();
            break;
          }
          case 32: {
            NextCrit = input.ReadBool();
            break;
          }
          case 40: {
            HpCurrentEnemy = input.ReadInt64();
            break;
          }
          case 48: {
            HpCurrentPlayer = input.ReadInt64();
            break;
          }
          case 56: {
            Level = input.ReadInt32();
            break;
          }
          case 64: {
            EnemyDodges = input.ReadBool();
            break;
          }
          case 72: {
            PlayerDodges = input.ReadBool();
            break;
          }
          case 802: {
            if (tempClientStatsHelper_ == null) {
              TempClientStatsHelper = new global::WUProtos.Data.Combat.CombatResults.Types.TempClientStatsHelper();
            }
            input.ReadMessage(TempClientStatsHelper);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CombatResults message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class TempClientStatsHelper : pb::IMessage<TempClientStatsHelper> {
        private static readonly pb::MessageParser<TempClientStatsHelper> _parser = new pb::MessageParser<TempClientStatsHelper>(() => new TempClientStatsHelper());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<TempClientStatsHelper> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Data.Combat.CombatResults.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TempClientStatsHelper() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TempClientStatsHelper(TempClientStatsHelper other) : this() {
          playerActiveStats_ = other.playerActiveStats_.Clone();
          enemyActiveStats_ = other.enemyActiveStats_.Clone();
          hpMaxEnemy_ = other.hpMaxEnemy_;
          enemyDamageUnblocked_ = other.enemyDamageUnblocked_.Clone();
          enemyDamageBlocked_ = other.enemyDamageBlocked_.Clone();
          hpMaxPlayer_ = other.hpMaxPlayer_;
          playerDamagePerEnergy_ = other.playerDamagePerEnergy_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TempClientStatsHelper Clone() {
          return new TempClientStatsHelper(this);
        }

        /// <summary>Field number for the "player_active_stats" field.</summary>
        public const int PlayerActiveStatsFieldNumber = 1;
        private static readonly pbc::MapField<string, long>.Codec _map_playerActiveStats_codec
            = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt64(16), 10);
        private readonly pbc::MapField<string, long> playerActiveStats_ = new pbc::MapField<string, long>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, long> PlayerActiveStats {
          get { return playerActiveStats_; }
        }

        /// <summary>Field number for the "enemy_active_stats" field.</summary>
        public const int EnemyActiveStatsFieldNumber = 2;
        private static readonly pbc::MapField<string, long>.Codec _map_enemyActiveStats_codec
            = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt64(16), 18);
        private readonly pbc::MapField<string, long> enemyActiveStats_ = new pbc::MapField<string, long>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, long> EnemyActiveStats {
          get { return enemyActiveStats_; }
        }

        /// <summary>Field number for the "hp_max_enemy" field.</summary>
        public const int HpMaxEnemyFieldNumber = 3;
        private long hpMaxEnemy_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long HpMaxEnemy {
          get { return hpMaxEnemy_; }
          set {
            hpMaxEnemy_ = value;
          }
        }

        /// <summary>Field number for the "enemy_damage_unblocked" field.</summary>
        public const int EnemyDamageUnblockedFieldNumber = 4;
        private static readonly pb::FieldCodec<long> _repeated_enemyDamageUnblocked_codec
            = pb::FieldCodec.ForInt64(34);
        private readonly pbc::RepeatedField<long> enemyDamageUnblocked_ = new pbc::RepeatedField<long>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<long> EnemyDamageUnblocked {
          get { return enemyDamageUnblocked_; }
        }

        /// <summary>Field number for the "enemy_damage_blocked" field.</summary>
        public const int EnemyDamageBlockedFieldNumber = 5;
        private static readonly pb::FieldCodec<long> _repeated_enemyDamageBlocked_codec
            = pb::FieldCodec.ForInt64(42);
        private readonly pbc::RepeatedField<long> enemyDamageBlocked_ = new pbc::RepeatedField<long>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<long> EnemyDamageBlocked {
          get { return enemyDamageBlocked_; }
        }

        /// <summary>Field number for the "hp_max_player" field.</summary>
        public const int HpMaxPlayerFieldNumber = 6;
        private long hpMaxPlayer_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long HpMaxPlayer {
          get { return hpMaxPlayer_; }
          set {
            hpMaxPlayer_ = value;
          }
        }

        /// <summary>Field number for the "player_damage_per_energy" field.</summary>
        public const int PlayerDamagePerEnergyFieldNumber = 7;
        private static readonly pbc::MapField<string, long>.Codec _map_playerDamagePerEnergy_codec
            = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt64(16), 58);
        private readonly pbc::MapField<string, long> playerDamagePerEnergy_ = new pbc::MapField<string, long>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, long> PlayerDamagePerEnergy {
          get { return playerDamagePerEnergy_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as TempClientStatsHelper);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(TempClientStatsHelper other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!PlayerActiveStats.Equals(other.PlayerActiveStats)) return false;
          if (!EnemyActiveStats.Equals(other.EnemyActiveStats)) return false;
          if (HpMaxEnemy != other.HpMaxEnemy) return false;
          if(!enemyDamageUnblocked_.Equals(other.enemyDamageUnblocked_)) return false;
          if(!enemyDamageBlocked_.Equals(other.enemyDamageBlocked_)) return false;
          if (HpMaxPlayer != other.HpMaxPlayer) return false;
          if (!PlayerDamagePerEnergy.Equals(other.PlayerDamagePerEnergy)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= PlayerActiveStats.GetHashCode();
          hash ^= EnemyActiveStats.GetHashCode();
          if (HpMaxEnemy != 0L) hash ^= HpMaxEnemy.GetHashCode();
          hash ^= enemyDamageUnblocked_.GetHashCode();
          hash ^= enemyDamageBlocked_.GetHashCode();
          if (HpMaxPlayer != 0L) hash ^= HpMaxPlayer.GetHashCode();
          hash ^= PlayerDamagePerEnergy.GetHashCode();
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
          playerActiveStats_.WriteTo(output, _map_playerActiveStats_codec);
          enemyActiveStats_.WriteTo(output, _map_enemyActiveStats_codec);
          if (HpMaxEnemy != 0L) {
            output.WriteRawTag(24);
            output.WriteInt64(HpMaxEnemy);
          }
          enemyDamageUnblocked_.WriteTo(output, _repeated_enemyDamageUnblocked_codec);
          enemyDamageBlocked_.WriteTo(output, _repeated_enemyDamageBlocked_codec);
          if (HpMaxPlayer != 0L) {
            output.WriteRawTag(48);
            output.WriteInt64(HpMaxPlayer);
          }
          playerDamagePerEnergy_.WriteTo(output, _map_playerDamagePerEnergy_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += playerActiveStats_.CalculateSize(_map_playerActiveStats_codec);
          size += enemyActiveStats_.CalculateSize(_map_enemyActiveStats_codec);
          if (HpMaxEnemy != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(HpMaxEnemy);
          }
          size += enemyDamageUnblocked_.CalculateSize(_repeated_enemyDamageUnblocked_codec);
          size += enemyDamageBlocked_.CalculateSize(_repeated_enemyDamageBlocked_codec);
          if (HpMaxPlayer != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(HpMaxPlayer);
          }
          size += playerDamagePerEnergy_.CalculateSize(_map_playerDamagePerEnergy_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(TempClientStatsHelper other) {
          if (other == null) {
            return;
          }
          playerActiveStats_.Add(other.playerActiveStats_);
          enemyActiveStats_.Add(other.enemyActiveStats_);
          if (other.HpMaxEnemy != 0L) {
            HpMaxEnemy = other.HpMaxEnemy;
          }
          enemyDamageUnblocked_.Add(other.enemyDamageUnblocked_);
          enemyDamageBlocked_.Add(other.enemyDamageBlocked_);
          if (other.HpMaxPlayer != 0L) {
            HpMaxPlayer = other.HpMaxPlayer;
          }
          playerDamagePerEnergy_.Add(other.playerDamagePerEnergy_);
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
                playerActiveStats_.AddEntriesFrom(input, _map_playerActiveStats_codec);
                break;
              }
              case 18: {
                enemyActiveStats_.AddEntriesFrom(input, _map_enemyActiveStats_codec);
                break;
              }
              case 24: {
                HpMaxEnemy = input.ReadInt64();
                break;
              }
              case 34:
              case 32: {
                enemyDamageUnblocked_.AddEntriesFrom(input, _repeated_enemyDamageUnblocked_codec);
                break;
              }
              case 42:
              case 40: {
                enemyDamageBlocked_.AddEntriesFrom(input, _repeated_enemyDamageBlocked_codec);
                break;
              }
              case 48: {
                HpMaxPlayer = input.ReadInt64();
                break;
              }
              case 58: {
                playerDamagePerEnergy_.AddEntriesFrom(input, _map_playerDamagePerEnergy_codec);
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
