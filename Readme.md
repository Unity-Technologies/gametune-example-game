# Endless Runner Sample game

## Cloning note

**This repository use git Large File Support. To clone it successfully, you will need to install git lfs** :

- Download git lfs here : https://git-lfs.github.com/
- Run `git lfs install` in a command line

Now you git clone should get the LFS files properly. For support of LFS in Git GUI client, please refer to their respective documentation

## Setup

- Developed and tested on **Unity 2019.2.3f1**
- For code styles `brew install uncrustify` -> `./scripts/codestyles.sh`
- For building and running on device
    - Add Bundle identifier in Player Settings
    - To make Unity Ads work add iOS and Android Game IDs to PackageInitializer in Start scene
    - To make Unity GameTune work add Unity Project ID to PackageInitializer in Start scene

## Branch details

This branch is cloned and slightly modified version of [EndlessRunnerSampleGame](https://github.com/Unity-Technologies/EndlessRunnerSampleGame)

Contents:
- Trash Dash game 
- UnityAds 3.0.1 package and integration
- UnityGameTune 2.0.0 package

## GameTune info

[GameTune documentation](http://docs.gametune.unity3d.com/)
