# MBest Boring Simulator

A virtualisation of Monash BEST's tunnel boring tool into VR. Primarily for showcasing purposes and display of VR and the tunnel boring tool's capabilities.

[![Unity 2022.3.36f1](https://img.shields.io/badge/Unity-2022.3.36f1-blue)](https://unity.com/)

---

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Dependencies](#dependencies)
  - [Installing](#installing)
  - [Executing programnning](#executing--programnning)
- [Project Structure](#project-structure)
- [Help](#help)
- [Version History](#version-history)

---

## Description

MBest Boring Simulator is a Unity-powered VR experience that virtualises Monash BEST’s tunnel boring machine ("Gaia 1").  
Visitors can pick up the model, spin it, toggle machine animations on/off, and view its 3 distinct layers, much like toggling floors in Google Maps.
This build is for an upcoming showcase and also serves as a reusable demo for future MBEST and MNET collaborations.

---

## Features

- **Layered Model**
  - Showcase the 3 layers of "Gaia 1".
- **Interactive Animations**
  - Machine animations which can be triggered on/off by the user.
- **Grab & Inspect**
  - Pick up, move, and spin the model using VR controllers.
- **Performance-Optimised**
  - Optimised mesh complexity so it runs smoothly on VR headsets.
- **Toggle Views**
  - Click UI buttons to show/hide individual layers (user can select the layer they wish to view).

---

## Getting Started

### Dependencies

- **Unity Editor**: 2022.3.36f1 (LTS)
- **Scriptable Render Pipeline**
  - Universal RP v14.0.11
- **XR & VR**
  - XR Interaction Toolkit v2.5.4
  - XR Management v4.4.0
  - OpenXR Plugin v1.11.0
- **Supported Headsets**
  - **Oculus Quest (1 & 2)** via OpenXR (our primary dev/test devices)
  - **Other OpenXR-compatible** headsets should work, though controller bindings may need tweaking.

### Installing

1. **Clone the repo**

```bash
   git clone https://github.com/Monash-Emerging-Tech/mbest-boring-sim.git
   cd mbest-boring-sim
```

2. **Open in Unity Hub**

- Click Add, navigate to the cloned folder.
- Select Unity 2022.3.36f1 (or install via Hub if missing).

2. **Restore packages**

- Unity will detect the **Packages/manifest.json** file and auto-install everything.
- If you see any missing packages under **Window** > **Package Manager**, hit Install on the ones called out in Dependencies.

### Executing program

1. **Open Unity Project**

- In the Project window, navigate **Assets** > **Scenes** and double click **RigScene.unity**.

2. **Press Play in the Editor**

- Press ▶ Play in the Unity Editor.

3. **Put on your VR headset and grab the controllers.**

---

## Project Structure

```
mbest-boring-sim/
├── Assets/
│   ├── Decals/
│   ├── Materials/
│   ├── MBEST/
│   ├── Meshes/
│   ├── Scenes/             # .unity scenes
│   ├── Skyboxes/
│   ├── TextMesh Pro/
│   ├── Videos/
│   ├── XR/
│   └── XRI/
├── Library/
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
├── ProjectSettings/
├── Temp/
├── UserSettings/
├── .gitignore
├── mbest-boring-sim.sln
├── Assembly-CSSharp.csproj
├── Unity.XR.Interaction.Toolkit.Samples.StarterAssets.csproj
├── UpgradeLog.htm
└── README.md               # ← you are here
```

---

## Help

- **Missing packages:** Open **Window** > **Package Manager**, search for XR Interaction Toolkit and click Install.

---

## Version History

v1.0.0

---
