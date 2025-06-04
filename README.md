# BlueprintBuddyApp
Homework app

Отлично! Вот шаблоны сообщений для ручного взаимодействия с агентом, разбитые по шагам. Ты можешь использовать их последовательно, копируя и вставляя в чат Copilot или другой среде, где работает агент.


---

🧭 ШАГ 1: Сравнение веток

Step 1: Compare the current branch with `master`.

Please list all newly added or modified files in this branch, compared to `master`. Include only files that have actual changes — ignore renamed or moved files without modifications.


---

🗂 ШАГ 2: Группировка по логике

Step 2: Group changed files by feature, module, or domain area.

Please organize the list of changed files into logical groups, based on their functional purpose or location in the project structure.


---

🔍 ШАГ 3: Анализ по частям (для каждой группы)

Step 3: Begin batch code review for the first group.

For this group:
1. Review all newly added or modified code only (ignore unrelated lines).
2. Check whether the code is consistent with the existing style and logic in the same file.
3. Note deviations in naming, structure, error handling, or security practices.
4. Summarize what changed and why it's important.
5. Suggest improvements: possible deduplication, better separation of concerns, or reusable components.

Once you're done, I will send the next group.

> 📌 Повтори этот промт вручную для каждой следующей группы, изменяя только строчку Begin batch code review for the N-th group.




---

🧱 ШАГ 4: Финальный архитектурный анализ

Step 4: Perform final architectural review across all batches.

Please:
1. Review all the changes across all files and groups.
2. Identify whether any group of files represents a self-contained or reusable feature.
3. Suggest how to encapsulate these in one place (e.g., into a domain module or service).
4. Identify any duplication of responsibilities across files.
5. Propose architecture improvements: abstraction, refactoring, improved modularity or layering.

Summarize your findings in bullet points or a short paragraph.


---

📝 ШАГ 5: Подготовка итогового описания PR

Step 5: Prepare the final Pull Request description.

Please generate a clean, professional summary of the pull request, including:
- Overview of all major changes
- Reason and context behind these changes
- Notable risks or design decisions
- Recommended reviewers or test cases (if applicable)

This PR is intended for an enterprise-grade banking project, so clarity and completeness are essential.


---

Можешь сохранить это как шаблон ревью-процесса в Notion или таск-трекере. Хочешь, я оформлю это в виде Markdown-файла?







Отлично, это важное уточнение — проверка форматирования критична, особенно в корпоративной среде, где единообразие кода влияет на поддержку, читаемость и CI-проверки.

Вот обновлённый промт для Шага 3 (Batch review), с добавленной проверкой на форматирование и стили:


---

🔍 ШАГ 3: Анализ по частям с проверкой форматирования

Step 3: Begin batch code review for the next group.

For this group of changed files, do the following:

1. Review only the newly added or modified code.
2. Evaluate whether the new code is **consistent** with the existing code in the same file, with special attention to:
   - Naming conventions and logic grouping
   - Error handling and security practices
   - Dependency usage and code layering
   - Logging consistency

3. **Check formatting carefully:**
   - No removal of meaningful blank lines
   - No two unrelated statements on the same line (e.g., two `let` or `if` statements)
   - Curly braces and indentation should follow the file’s original style
   - Blank lines should be preserved or used appropriately
   - Ensure that the structure and whitespace match the prevailing formatting style in that file (e.g., spacing, tabs vs. spaces)

4. Write a brief **summary** for the group:
   - What was changed
   - Why the change was made
   - Any issues or risks
   - Suggestions for improvement or refactoring

Once done, I will provide the next group.


---

Этот шаг можно применять последовательно для всех групп, и он подойдёт даже для агентов, не имеющих встроенного линтера. Если у тебя в проекте есть конкретный .editorconfig, Prettier, или аналог, могу добавить инструкции по верификации в контексте этих инструментов. Скажи, если нужно.

