# LearnUnityECS

http://infalliblecode.com/


## Component

An object that contains raw data related to
one aspect of an entity.

Implemented as a MonoBehaviours or an IComponentData
struct in Unity.


## System

Performs logic on every entity that contains
a specific subset of components

Implemented as a ComponentSystem or JobComponentSystem
based classed in Unity.

## Entity

A general purpose object that contains a
collection of components.

Created using either the EnityManager or the
GmaeObjectEntity MonoBehaviour in Unity.
