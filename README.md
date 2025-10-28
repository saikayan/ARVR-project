#  AR Education Project (Unity 2025 – Version 6000.2.1f1)

An **Augmented Reality (AR)** application developed in **Unity 2025 (6000.2.1f1)** under the **Education domain**.  
The project visualizes interactive 3D educational content using markerless AR technology.

---

##  Overview

This project was inspired by the open-source educational AR template 
It has been **upgraded to the newer Unity 2025 engine** and includes several **optional features and improvements** for enhanced compatibility and interactivity.

---

##  Features

- Built using **Unity 2025 (6000.12f1)**  
- **Markerless AR** experience (works on Android without printed markers)  
- Interactive **3D models** (dragons, maps, solar system, animals, etc.)  
- Added animations and realistic textures  
- Compatible with **Android ARCore** devices  
- Optimized UI for mobile AR display  

---

## Tech Stack
____________________________________________________________________
| Component             |                  Description              |
|-----------------------|-------------------------------------------|
| **Engine**            | Unity 2025 (6000.2.1f1)                   |
| **SDK**               | TechXR / AR Foundation/vuforia            |
| **Platform**          | Android                                   |
| **Language**          | C#                                        |
| **Domain**            | Education – Interactive learning using AR |
---------------------------------------------------------------------
---

##  How to Run (In Unity Editor)

1. Clone or download this repository:
   ```bash
   git clone https://github.com/saikayan/AR-PROJECT.git

2. Open the project in Unity 2025 (6000.12f1) or a compatible version.
3. In the Project window, navigate to:
    Assets → Minor Project → Main Menu.unity
4. Double-click on Main Menu.unity to open the main scene.
5. Press the Play ▶ button on the Unity toolbar to run the project in the Editor.

##  To Run on Mobile (Android)

1. Connect your Android device via USB and enable Developer Mode + USB Debugging.

2. In Unity, go to File → Build Settings → Android.

3. Click Add Open Scenes (ensure Main Menu.unity is selected and other secens also).

4. Press Build and Run.

5. The app will automatically install and open on your phone — point the camera to explore AR models.
6. if you want an permanent app then you can click on the check box "export project" and "export app bundel" then click on the build and run , approx it will take 20 to 25 min  or 10 min if you have a good laptop/pc.

# Handling Compilation Issues in Unity 6000.x 
if you see any of these errors :
1. Library\PackageCache\com.unity.postprocessing@1219183348c4\PostProcessing\Runtime\PostProcessManager.cs(424,66): error CS0117: 'EditorSceneManager' does not contain a definition for 'IsGameObjectInScene'
2.  2. Library\PackageCache\com.unity.postprocessing@1219183348c4\PostProcessing\Runtime\Utils\TextureFormatUtilities.cs(67,24): error CS0619: 'TextureFormat.ETC_RGB4_3DS' is obsolete: 'Enum member ETC_RGB4_3DS is obsolete. Nintendo 3DS is no longer supported.'
       

---

##  Root Cause

These errors occur because **Unity 6000.x** removed or renamed some old APIs used by outdated packages.

Specifically:
- `EditorSceneManager.IsGameObjectInScene` →  Removed  
- `TextureFormat.ETC_RGB4_3DS` →  Deprecated  

The project originally used an old **Post Processing** package (`com.unity.postprocessing@2.0.3-preview`) that references these APIs.  
This caused dependent packages (like **Vuforia Engine**) to fail compilation.

---

##  Fix Steps

### **Step 1: Remove the Old Post-Processing Package**

1. Open **Window → Package Manager** in Unity.  
2. Find any package named **Post Processing** or `com.unity.postprocessing`.  
3. Click **Remove ** to uninstall it.  
4. Wait for Unity to recompile automatically.

---

### **Step 2: Clear Cached Package Data**

1. Go to your project folder and delete:Library/PackageCache/com.unity.postprocessing@...
2. (Optional) You can delete the entire `Library/` folder — Unity will rebuild it automatically.  
3. Reopen the project in Unity.

---

### **Step 3: Reinstall a Compatible Version (Optional)**

If you need visual effects (like **Bloom** or **Vignette**):

1. Open **Package Manager → Add → Add package by name...**  
2. Enter:com.unity.postprocessing
3. This installs the latest **3.x version**, fully compatible with Unity 6000.x and Vuforia.  

>  If you don’t use post-processing effects in your version, you can skip this step safely.

---

### **Step 4: Final Clean & Test**

1. Go to **Assets → Reimport All**  
2. Then **File → Build Settings → Build and Run**  
3. Confirm that your **console shows no compile errors** 




# Acknowledgements

- Upgraded and enhanced for Unity 2025 compatibility with new features, animations, and optimizations.
