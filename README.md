# Intimacy Mood Tuner

RimWorld мод (C# + XML). Позволяет настроить бонусы настроения каждой стадии потребности Intimacy из мода [Intimacy - A Lovin' Expansion](https://steamcommunity.com/sharedfiles/filedetails/?id=3498422643).

**Зависимость:** `LovelyDovey.Sex.WithEuterpe`

## Стадии по умолчанию

| Stage | Label | Оригинал | Мод |
|-------|-------|----------|-----|
| 0 | craving intimacy | -4 | -4 |
| 1 | comfortably social | 0 | 0 |
| 2 | in good company | +4 | +1 |
| 3 | cherished | +8 | +2 |
| 4 | cozy and ecstatic | +12 | +3 |

Значения меняются в меню настроек модов RimWorld.

## Сборка

```bash
cd Source
dotnet build
```

DLL выходит в `mod/Assemblies/`. После сборки — закоммитить DLL.
