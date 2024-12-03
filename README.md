# **Learning C# in Unity: Unity Lifecycle Methods**  

This project introduces essential Unity lifecycle methods: **Awake**, **OnEnable**, **Start**, **Update**, and **FixedUpdate**. Understanding these methods is crucial for learning C# in Unity and effectively managing game logic and behavior.  

---

## 🎯 **Project Overview**  

Unity's lifecycle methods define the execution order of scripts and control how your code interacts with the engine. This project demonstrates these key methods in a simple and practical way to help you understand their purpose and execution order.

---

## ✨ **Features**  

1. **Awake**: Runs when the script instance is initialized.  
2. **OnEnable**: Called every time the object or script is enabled.  
3. **Start**: Executes before the first frame update after the object is enabled.  
4. **Update**: Runs once per frame for real-time game logic.  
5. **FixedUpdate**: Executes at a fixed time interval for physics updates.  

---

## 🚀 **Getting Started**  

### **Prerequisites**  
- **Unity**: Version 2020.3 or higher.  
- Basic understanding of Unity and C#.  

---

## 🎮 **How to Use the Project**  

1. **Create a New Unity Project**:  
   - Open Unity Hub and create a new 3D project.  

2. **Add the Script**:  
   - Create a new script (e.g., `LifecycleExample.cs`) in the **Assets/Scripts** folder.  
   - Copy and paste the example scripts into it.  

3. **Attach the Script**:  
   - Attach the script to an empty GameObject in your scene.  

4. **Run the Scene**:  
   - Press Play and observe the **Console** output to see the execution order of the methods.  

---

## 🔮 **Key Learnings**  

- **Understand the Execution Order**:  
  The order is typically: `Awake → OnEnable → Start → FixedUpdate → Update`.  
- **Know When to Use Each Method**:  
  - Use **Awake** for initialization.  
  - Use **OnEnable** for enabling-specific behavior.  
  - Use **Start** for setup after initialization.  
  - Use **Update** for frame-dependent logic.  
  - Use **FixedUpdate** for physics-based updates.  

---


## 📜 **License**  

This project is for educational purposes and is free to use and modify.  

---  
