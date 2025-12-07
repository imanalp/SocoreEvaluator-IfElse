# 🎯 ScoreEvaluator — If/Else Logic Project

![C#](https://img.shields.io/badge/Language-C%23-blue)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)
![Open Source](https://img.shields.io/badge/Open%20Source-Yes-green)
![Clean Code](https://img.shields.io/badge/Clean%20Code-Approved-yellow)

## 📌 Overview
ScoreEvaluator is a clean and well-structured C# console application that uses  
if / else conditions to calculate a *final score* based on *Age, **GPA, and **Work Experience*.

The goal of the project is to practice:
- Writing clean conditional logic  
- Handling user input safely  
- Separating code into small, readable methods  
- Producing organized console applications  

---

## ✨ Features
- Input validation using TryParse
- Separate methods for each scoring category
- Clear and maintainable code structure
- Automatic final score calculation
- Meaningful result messages (Excellent, Suitable, Needs Review, Not Approved)

---

## 🧮 Scoring System

### 🔹 Age Score
The program evaluates the user’s age and assigns points.  
Younger users receive higher points, and older users receive slightly lower scores.

### 🔹 GPA Score
Higher GPAs earn more points.  
Exceptional academic performance increases the final score.

### 🔹 Work Experience Score
More years of experience lead to higher points.  
Beginners get a small score, while experienced individuals earn higher values.

### 🔹 Final Evaluation
After calculating Age + GPA + Experience, the program produces a final result:  
- A high total score results in *Excellent*  
- Medium scores give *Suitable*  
- Low scores lead to *Needs Review*  
- Very low scores return *Not Approved*

---

## 🚀 How to Run

### 1️⃣ Clone the repository
```bash
https://github.com/imanalp/SocoreEvaluator-IfElse
2️⃣ Open in Visual Studio

Open the .sln file.

3️⃣ Run the project

Press F5 or Ctrl + F5 to start.

4️⃣ Enter your information

The program will guide you through entering:
	•	Age
	•	GPA
	•	Work Experience

All values are validated before scoring.
🧱 Project Structure
ScoreEvaluator/
 ├── Program.cs
 ├── Methods:
 │     - ReadIntInput()
 │     - CalculateAgeScore()
 │     - CalculateGpaScore()
 │     - CalculateExperienceScore()
 │     - EvaluateFinalResult()
 └── README.md
💡 Purpose

This project is perfect for practicing:
	•	if / else logic
	•	Input validation
	•	Clean code structure
	•	Method-based programming

⸻

🤝 Contributing

Fork the project and submit improvements anytime.

⸻

📄 License

Licensed under the MIT License.

⸻

⭐ Support

If you enjoy this project, consider giving it a ⭐ on GitHub!
