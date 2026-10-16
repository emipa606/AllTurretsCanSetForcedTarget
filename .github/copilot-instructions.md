# GitHub Copilot Instructions

## Mod Overview and Purpose

**Mod Name:** All Turrets Can Set Forced Target (Continued)

The "All Turrets Can Set Forced Target (Continued)" mod is an update to the original mod by BaalEvan. This mod enhances the gameplay experience in RimWorld by allowing all player-controlled turrets to set a forced target. This means players can specify exactly which enemy their turret should focus on, providing more strategic control during combat scenarios.

### Version Information
- **Version:** 1.0.4
- **Compatibility:** Works with RimWorld versions 1.2, 1.3, and 1.4.

## Key Features and Systems

- **Forced Targeting:** Enables players to assign a specific target for all their turrets, regardless of the turret type.
- **Compatibility:** No requirement for HugsLib, simplifying the mod setup and enhancing compatibility with RimWorld versions mentioned above.
- **Support/System Suggestion:** Encourages the use of RimSort to organize your mods and offers support via a Discord channel for error reporting.

## Coding Patterns and Conventions

### C# Conventions
- **Type Naming:** Use PascalCase for class and type names such as `AllTurretsCanSetForcedTarget` and `Building_TurretGun_CanSetForcedTarget`.
- **Method Naming:** Use PascalCase for method names, e.g., `Postfix`, `TargetMethods`.
- **Member Access:** Use explicit access modifiers for all classes and methods (e.g., `public`, `private`).

### XML Integration
- **Structure:** Ensure XML files are well-formed, with a clear declaration of dependencies as necessary.
- **Dependencies:** Specify mod dependencies such as `UnlimitedHugs.HugsLib` within the `About.xml` file, maintaining compatibility with other mods.

## Harmony Patching

**Harmony** is a library used to modify the game’s behavior without altering its source code.

- **Patch Classes:** Implement Harmony patches within separate classes such as `Building_TurretGun_CanSetForcedTarget` to extend or modify turret functionality.
- **Prefix/Postfix Methods:** Use `Postfix` methods to append new behaviors after original game methods have executed. Ensure methods are defined with the appropriate attributes and parameters for Harmony patches.
- **Target Methods:** Clearly define which game methods are being patched via `TargetMethods`, maintaining a clear map of original vs. modified functions.

## Suggestions for Copilot

- **Automatic Suggestion Enhancements:** Recommend adding comments and documentation strings that provide context for each method, class, or action within the code to enhance code readability and facilitate Copilot’s predictive capabilities.
- **AI-Assisted Refactoring:** Use Copilot to refactor existing methods for improved readability and performance where applicable, focusing on streamlining method logic.
- **Pattern Recognition:** Leverage Copilot’s strength in identifying repetitive patterns to ensure consistent coding conventions and practices across the entire codebase, especially relevant for Harmony patches and XML integration.
- **Test Generation:** Assist in generating test cases to verify that new features or changes do not introduce bugs, particularly focusing on the functionality of forcing turret targets.

By following these guidelines, contributors can maintain the consistent quality and functionality of the "All Turrets Can Set Forced Target (Continued)" mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

