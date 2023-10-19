# Artemis Plugin Templates

This repository contains templates for Artemis plugins. Available on Nuget ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/ArtemisRGB.Templates)

These templates are intended to be used if you know your way around Artemis plugins, especially if you already have a repository with some plugins and want to add a new one.
If you're starting out with Artemis plugins, it's recommended to use the [Artemis Template Repository](https://github.com/Artemis-RGB/Artemis.PluginTemplate) on Github.

## Pre-requisites

- [.NET SDK](https://dotnet.microsoft.com/download) (required)
- Code editor of your choice (recommended):
  - [Rider](https://www.jetbrains.com/rider/)
  - [Visual Studio 2022](https://visualstudio.microsoft.com/vs/community/)
  - [Visual Studio Code](https://code.visualstudio.com/)

## Installation

To install the templates, run the following command:

```bash
dotnet new install ArtemisRGB.Templates
```

You can see all available templates by running

```bash
dotnet new list artemis
```

To update the templates, run the following command:

```bash
dotnet new update
```

## Usage

### Empty Plugin

```bash
dotnet new artemis-plugin-empty -n Artemis.Plugins.ExamplePlugin
```

Empty Artemis plugin project, without any modules or layers.

### Module Plugin

```bash
dotnet new artemis-plugin-module -n Artemis.Plugins.Modules.ExampleModule --moduleName Example
```

Creates an Artemis plugin project with a single module. This is used to add external data for Artemis to use, such as CPU or GPU temperatures, current weather, etc.

### Layer Brush Plugin

```bash
dotnet new artemis-plugin-layerbrush -n Artemis.Plugins.LayerBrushes.ExampleLayerBrush --layerBrushName Example
```

Creates an Artemis plugin project with a single layer brush. This is used to add a new brush to the editor, such as a gradient or a noise brush.

### Layer Effect Plugin

```bash
dotnet new artemis-plugin-layereffect -n Artemis.Plugins.LayerEffects.ExampleLayerEffect --layerEffectName Example
```

Creates an Artemis plugin project with a single layer effect. This is used to add a new effect to the editor, which can be applied to a layer.
