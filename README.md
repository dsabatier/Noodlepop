# Noodlepop

Noodlepop is a collection of tools, extensions and utilities for the Unity3D game engine that I have been building on and carrying from project to project since 2017.

Some of the features included:

- **AudioEvents:** ScriptableObjects to easily implement audio basics in your game, inspired by [this talk](https://www.youtube.com/watch?v=6vmRwLYWNRo) by Richard Fine
-  **FiniteStateMachine:** A very basic implementation of a finite state machine.
- **GameEvents:** ScriptableObjects that can be used to raise events in your game and MonoBehaviours that listen and execute UnityEvents.  Extremely flexible and decouples events from their receivers.  The most common way to use these are with UI: A Button can fire some GameEvent and any number of listeners can respond.  If there are no listeners, nothing happens.  This is very nice when separate UI from gameplay.
- **VariableAssets:** ScriptableObjects wrapped around variables.  Allows references to any value or reference type to be passed using an asset, as well as easily saving changes in Play Mode.  I will often have values such as a players current health or other such stats wrapped in a VariableAsset so I can keep a reference to it in my UI.
- **Utility:** A few handy extensions: Custom editor attributes, property drawers, extension methods.

## Getting Started


For the latest release add the below dependencies to your projects packages.json.

```
{
  "dependencies": {
    "com.dsabatier.noodlepop": "https://github.com/dsabatier/Noodlepop.git#upm"
  }
}
```

Alternatively, clone this repo to a local folder and add the Asset folder to the Unity Package Manager.




```
git subtree push --prefix Assets origin upm
```
