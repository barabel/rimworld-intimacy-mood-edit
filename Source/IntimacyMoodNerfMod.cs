using RimWorld;
using UnityEngine;
using Verse;

namespace IntimacyMoodNerf
{
  public class IntimacyMoodNerfMod : Mod
  {
    private readonly IntimacyMoodNerfSettings settings;

    private string buf1, buf2, buf3, buf4, buf5;

    public IntimacyMoodNerfMod(ModContentPack content) : base(content)
    {
      settings = GetSettings<IntimacyMoodNerfSettings>();
      LongEventHandler.ExecuteWhenFinished(ApplySettings);
    }

    internal void ApplySettings()
    {
      ThoughtDef def = DefDatabase<ThoughtDef>.GetNamedSilentFail("SEX_Intimacy");
      if (def?.stages == null || def.stages.Count < 5) return;

      def.stages[0].baseMoodEffect = settings.stage1;
      def.stages[1].baseMoodEffect = settings.stage2;
      def.stages[2].baseMoodEffect = settings.stage3;
      def.stages[3].baseMoodEffect = settings.stage4;
      def.stages[4].baseMoodEffect = settings.stage5;
    }

    public override string SettingsCategory() => "Intimacy Mood Nerf";

    public override void DoSettingsWindowContents(Rect inRect)
    {
      Listing_Standard listing = new Listing_Standard();
      listing.Begin(inRect);

      DrawStageRow(listing, "Craving intimacy",   "-4",  ref settings.stage1, ref buf1);
      DrawStageRow(listing, "Comfortably social", "0",   ref settings.stage2, ref buf2);
      DrawStageRow(listing, "In good company",    "+4",  ref settings.stage3, ref buf3);
      DrawStageRow(listing, "Cherished",          "+8",  ref settings.stage4, ref buf4);
      DrawStageRow(listing, "Cozy and ecstatic",  "+12", ref settings.stage5, ref buf5);

      listing.Gap(12f);

      if (listing.ButtonText("Reset to mod defaults"))
      {
        settings.Reset();
        buf1 = buf2 = buf3 = buf4 = buf5 = null;
        ApplySettings();
      }

      listing.End();
    }

    private static void DrawStageRow(Listing_Standard listing, string label, string vanilla, ref float value, ref string buffer)
    {
      Rect row = listing.GetRect(Text.LineHeight + 4f);

      Widgets.Label(row.LeftPart(0.6f), label);
      Widgets.TextFieldNumeric(row.LeftPart(0.85f).RightPart(0.29f), ref value, ref buffer, -50f, 50f);

      GUI.color = Color.gray;
      Widgets.Label(row.RightPart(0.15f), $"vanilla: {vanilla}");
      GUI.color = Color.white;

      listing.Gap(4f);
    }

    public override void WriteSettings()
    {
      base.WriteSettings();
      ApplySettings();
    }
  }
}
