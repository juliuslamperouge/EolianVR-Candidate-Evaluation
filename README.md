# EolianVR-Candidate-Evaluation

- Create a unity project deployable to HoloLens using MRTK that will:
  - Compile and run
  - Recognize hands and at least the click gesture
- Stretch goal
  - Fire a ball when the click gesture is recognized that interacts with spatially meshed terrain

---

### Build

Access the build window in the Unity editor  `Mixed Reality > Toolkit > Utilities > Build Window`.

#### If you go to build Appx and get...

`error MSB3774: Could not find SDK "WindowsMobile, Version=10.0.22621.0"`

Delete this generated xml in the `.vcxproj` file (`<repo>\Builds\WSAPlayer\ucaz-EolianVR\ucaz-EolianVR.vcxproj`)
```xml
  <ItemGroup>
    <SDKReference Include="WindowsMobile, Version=10.0.22621.0" />
  </ItemGroup>
```
