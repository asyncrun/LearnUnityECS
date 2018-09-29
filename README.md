# LearnUnityECS
LearnUnityECS

http://infalliblecode.com/

part 1 configured the editor and 
imported the Entities package, which
contained all the classes need to
work with Unity ECS.


1/Create Project
2/Setting .Net 4.x Equivalent
3/Packgae Manager
4/Debug -> Entity Debugger


Part 2
implementing the first half of player
movement

always think in terms of data and behavior

Data is stoted within components,


*******************************************************
Component

An object that contains raw data related to
one aspect of an entity.

Implemented as a MonoBehaviours or an IComponentData
struct in Unity.

*******************************************************
System

Performs logic on every entity that contains
a specific subset of components

Implemented as a ComponentSystem or JobComponentSystem
based classed in Unity.

*******************************************************
Entity

A general purpose object that contains a
collection of components.

Created using either the EnityManager or the
GmaeObjectEntity MonoBehaviour in Unity.
