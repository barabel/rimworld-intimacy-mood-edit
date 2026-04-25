# Intimacy Mood Tuner

RimWorld mod. Lets you tune the mood bonuses for each stage of the Intimacy need from [Intimacy - A Lovin' Expansion](https://steamcommunity.com/sharedfiles/filedetails/?id=3498422643).

**Dependency:** `LovelyDovey.Sex.WithEuterpe`

## Stages

| Stage | Label | Vanilla | Mod |
|-------|-------|----------|-----|
| 0 | craving intimacy | -4 | -4 |
| 1 | comfortably social | 0 | 0 |
| 2 | in good company | +4 | +1 |
| 3 | cherished | +8 | +2 |
| 4 | cozy and ecstatic | +12 | +3 |

Values can be changed in the RimWorld mod settings menu.

## Installation

The compiled mod is in the `mod/` folder. Copy it to your RimWorld mods directory:

```
<RimWorld>/Mods/
```

## Build

```bash
cd Source
dotnet build
```

DLL outputs to `mod/Assemblies/`. Commit the DLL after building.
