# Artemis Plugin Templates

This repository contains templates for Artemis plugins. Available on Nuget ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/ArtemisRGB.Templates)

## Pre-requisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download) (required)
- Code editor of your choice (optional):
    - [Visual Studio 2022](https://visualstudio.microsoft.com/vs/community/) (recommended)
    - [Visual Studio Code](https://code.visualstudio.com/)

## Installation

To install the templates, run the following command:

```bash
dotnet new -i ArtemisRGB.Templates
```

You can see all available templates by running 
```bash
dotnet new -l artemis
```

To update the templates, run the following command:

```bash
dotnet new --update-apply
```

## Usage

To get started creating plugins for Artemis, the repository template is recommended. Tt comes with gitignore to keep your project clean, and GitHub Actions set up to automatically build and publish your plugin. It's also very easy to add more plugins later.

To create a new plugin repository, run the following command in a new empty folder:

```bash
dotnet new artemis-plugin-repo
```

This repository cannot be created in Visual Studio like the plugin projects, it is intended for use with the dotnet CLI.

Any templates after this point are intended to be added to an existing repository created by the repository template, which can be done in two ways:
- Visual Studio  via the `Add > New Project...` menu
-  dotnet CLI via the given commands.

## Available Templates

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

### Layer Effect Plugin (WIP)

```bash
dotnet new artemis-plugin-layereffect -n Artemis.Plugins.LayerEffects.ExampleLayerEffect --layerEffectName Example
```

Creates an Artemis plugin project with a single layer effect. This is used to add a new effect to the editor, which can be applied to a layer.