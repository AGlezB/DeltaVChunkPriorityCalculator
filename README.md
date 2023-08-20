# Chunk Priority Calculator POC for _ΔV: Rings of Saturn_

Proof of concept implementation of the 
[Tug/Haul drone tuning rework](https://discord.com/channels/426287934870781952/1141162164770586624)
community idea in the [Official Discord Server](https://discord.gg/dv).

This is a simple WinForms application meant for developers to build and debug.
There is no fancy code, unit testing, binaries releases, wiki, etc.

If you find a problem feel free to create an issue or a PR. Don't expect a quick answer.

## Requirements

- Windows
- VS 2022 with .NET desktop develoment workload.
- .NET 7.0

## _ΔV: Rings of Saturn_ and how to use

If you are not familiar with the game this repo will have very litte value for you.
You can find more about it on [GOG](https://www.gog.com/en/game/dv_rings_of_saturn) 
and [Steam](https://store.steampowered.com/app/846030/V_Rings_of_Saturn/).

For those familiar with the game the UI should be more or less self explanatory.
Mouse over the controls to see tooltips with some explanations.

## Important parts

Most of the code is UI stuff. Things to pay attention to:

- [Rules](Rules)/*.cs: the `Evaluate` method contains the actual logic or the rules.
- [RuleEngine.cs](RuleEngine.cs): the `CalculatePriority` method is the entry point for rule evaluation.
- [Examples](Examples)/*.json: some premade datasets to ease testing. You can load/save these from the UI.
  Keep in mind that in some cases it might be simpler to just manually copy and modify the files.

### Rules

The included rules are different from the ones in the original community idea.
This resulted from testing different combinations:

- [ChunkPriceRule](Rules/ChunkPriceRule.cs): Priority based on the market price of the chunk. 
- [ChunkSpeedRule](Rules/ChunkSpeedRule.cs): Priority base on how fast the chunk is moving relative to the ship.
- [OrePriceRule](Rules/OrePriceRule.cs): Priority based on the market price of the ore.- 

Those rules cover the most relevant scenarios.
I tested other rules but the benefits where marginal al best and they didn't add enough value to keep them
at the expense of the extra complexity.

Use `RuleWeightMultiplier` (the `Weight` in the rule UI) to individually change the relevance of the rules.