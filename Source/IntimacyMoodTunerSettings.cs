using Verse;

namespace IntimacyMoodTuner
{
  public class IntimacyMoodTunerSettings : ModSettings
  {
    public float stage1 = -4f;
    public float stage2 = 0f;
    public float stage3 = 1f;
    public float stage4 = 2f;
    public float stage5 = 3f;

    public void Reset()
    {
      stage1 = -4f;
      stage2 = 0f;
      stage3 = 1f;
      stage4 = 2f;
      stage5 = 3f;
    }

    public override void ExposeData()
    {
      Scribe_Values.Look(ref stage1, "stage1", -4f);
      Scribe_Values.Look(ref stage2, "stage2", 0f);
      Scribe_Values.Look(ref stage3, "stage3", 1f);
      Scribe_Values.Look(ref stage4, "stage4", 2f);
      Scribe_Values.Look(ref stage5, "stage5", 3f);
      base.ExposeData();
    }
  }
}
