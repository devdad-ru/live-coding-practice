# Как работать с задачами

## Дальнейший прогресс

Задачи не блокируют дальнейшее прохождение обучения и не требуют обязательной проверки ментором.
Решай их параллельно с теорией, чтобы прокачивать практику и быстрее набирать уверенность в коде.

Каждая задача содержит:

- формулировку,
- подсказки в комментариях,
- тесты для самопроверки.

## Зачем решать эти задачи

Даже если ты планируешь пользоваться нейросетями на собеседовании, важно уметь решать базовые задачи самостоятельно.
Это помогает понимать, корректен ли сгенерированный код, и уверенно объяснять решение.

Эти задачи помогут тебе:

- **Закрепить синтаксис C#** — массивы, коллекции, строки, LINQ, базовые алгоритмы.
- **Прокачать навык декомпозиции** — разбивать задачу на шаги и писать читаемый код.
- **Подготовиться к собеседованиям** — задачи основаны на популярных интервью-сценариях.

## Структура сложности

| Уровень | Навык | Задачи |
|---------|-------|--------|
| **Easy** | Базовые массивы и строки | 1-3 |
| **Medium** | Интервалы, LINQ, словари, стек | 4-8 |
| **Hard** | Матрицы и бинарный поиск | 9-10 |

**Рекомендация:** проходи по порядку. Следующие задачи опираются на предыдущие.

## Структура репозитория

- `LiveCodingTraining.sln` — общее решение.
- `src/LiveCodingTraining` — консольный проект с задачами.
- `tests/LiveCodingTraining.UnitTests` — xUnit-проект с тестами.

Файлы задач:

- `1.MoveZeroes.cs`
- `2.TwoSum.cs`
- `3.FindEvenIndex.cs`
- `4.MergeIntervals.cs`
- `5.MySkipLast.cs`
- `6.MyTakeLast.cs`
- `7.EvaluatePostfixExpression.cs`
- `8.IsIsomorphic.cs`
- `9.RotateMatrix90Clockwise.cs`
- `10.IsPerfectSquare.cs`

Файлы тестов:

- `1.MoveZeroesTests.cs`
- `2.TwoSumTests.cs`
- `3.FindEvenIndexTests.cs`
- `4.MergeIntervalsTests.cs`
- `5.MySkipLastTests.cs`
- `6.MyTakeLastTests.cs`
- `7.EvaluatePostfixExpressionTests.cs`
- `8.IsIsomorphicTests.cs`
- `9.RotateMatrix90ClockwiseTests.cs`
- `10.IsPerfectSquareTests.cs`

## Алгоритм работы с задачей

### Шаг 1. Открой решение

Открой `LiveCodingTraining.sln` в IDE.

### Шаг 2. Выбери задачу

Например, для первой задачи открой файл:

`src/LiveCodingTraining/1.MoveZeroes.cs`

### Шаг 3. Пойми условие (5 минут)

Прочитай `summary` метода и примеры.
Ответь себе:

- Что на входе?
- Что ожидается на выходе?
- Какие граничные случаи?

### Шаг 4. Попробуй решить (15-30 минут)

Не открывай готовое решение сразу.
Сначала набросай короткий план шагов в комментариях и реализуй его.

### Шаг 5. Проверь себя тестами

Запусти все тесты:

```bash
dotnet test LiveCodingTraining.sln
```

Или тесты только по текущей задаче:

```bash
dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MoveZeroesTests"
```

> Для xUnit в этом проекте надежнее использовать фильтр `FullyQualifiedName`.

### Шаг 6. Ручная проверка через консоль

```bash
dotnet run --project src/LiveCodingTraining/LiveCodingTraining.csproj
```

Далее выбери номер задачи в меню.
Программа покажет:

- какой метод запущен,
- какие входные данные поданы,
- какой получен выход,
- успешен запуск или нет.

## Как проверить решение

### 1. Быстрый прогон всех тестов

```bash
dotnet test LiveCodingTraining.sln
```

### 2. Запуск тестов конкретной задачи

```bash
dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~TwoSumTests"
```

### Таблица соответствия задач и команды фильтра

| № | Файл задачи | Файл тестов | Команда |
|---|-------------|-------------|---------|
| 1 | `1.MoveZeroes.cs` | `1.MoveZeroesTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MoveZeroesTests"` |
| 2 | `2.TwoSum.cs` | `2.TwoSumTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~TwoSumTests"` |
| 3 | `3.FindEvenIndex.cs` | `3.FindEvenIndexTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~FindEvenIndexTests"` |
| 4 | `4.MergeIntervals.cs` | `4.MergeIntervalsTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MergeIntervalsTests"` |
| 5 | `5.MySkipLast.cs` | `5.MySkipLastTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MySkipLastTests"` |
| 6 | `6.MyTakeLast.cs` | `6.MyTakeLastTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MyTakeLastTests"` |
| 7 | `7.EvaluatePostfixExpression.cs` | `7.EvaluatePostfixExpressionTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~EvaluatePostfixExpressionTests"` |
| 8 | `8.IsIsomorphic.cs` | `8.IsIsomorphicTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~IsIsomorphicTests"` |
| 9 | `9.RotateMatrix90Clockwise.cs` | `9.RotateMatrix90ClockwiseTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~RotateMatrix90ClockwiseTests"` |
| 10 | `10.IsPerfectSquare.cs` | `10.IsPerfectSquareTests.cs` | `dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~IsPerfectSquareTests"` |

### 3. Запуск одного тестового метода

```bash
dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MoveZeroes_WithAllZeroes_ReturnsSameLengthZeroArray"
```

### 4. Запуск только тестового проекта

```bash
dotnet test tests/LiveCodingTraining.UnitTests/LiveCodingTraining.UnitTests.csproj
```

## Полезные команды

```bash
# Восстановить пакеты
dotnet restore

# Сборка всего решения
dotnet build LiveCodingTraining.sln

# Запуск всех тестов
dotnet test LiveCodingTraining.sln

# Тесты конкретной задачи (пример)
dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MergeIntervalsTests"

# Один конкретный тест (пример)
dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MergeIntervals_WithNegativeBounds_WorksCorrectly"

# Запуск консольного приложения
dotnet run --project src/LiveCodingTraining/LiveCodingTraining.csproj
```

## Пример работы с задачей

### Задача 1: MoveZeroes

**Понимаю условие:**

- Вход: массив целых чисел.
- Выход: новый массив, где все нули перенесены в конец.
- Порядок ненулевых элементов должен сохраниться.

**План:**

1. Создать результирующий массив той же длины.
2. Пройти по исходному массиву.
3. Копировать в результат только ненулевые элементы.
4. Остальные позиции останутся нулями.

**Проверяю:**

```bash
dotnet test LiveCodingTraining.sln --filter "FullyQualifiedName~MoveZeroesTests"
```

Если тесты зелёные — задача решена корректно.

## Типичные ошибки

### Ошибка 1. "Сразу открыл готовое решение"

**Проблема:** не формируется навык самостоятельного решения.

**Решение:** дай себе минимум 15 минут самостоятельной попытки.

### Ошибка 2. "Тесты не запускаются по фильтру"

**Проблема:** `ClassName=...` может не сработать в текущем адаптере.

**Решение:** используй `FullyQualifiedName~...`.

Пример:

```bash
dotnet test --filter "FullyQualifiedName~IsPerfectSquareTests"
```

### Ошибка 3. "Проект не запускается, файл занят другим процессом"

**Проблема:** уже запущен экземпляр приложения и блокирует `exe`.

**Решение:** останови предыдущий запуск (`Ctrl+C`) и запусти снова.

### Ошибка 4. "Решил, но не проверил граничные случаи"

**Проблема:** код работает на примере, но ломается на пустом входе/null.

**Решение:** всегда прогоняй тесты и думай о крайних сценариях.

## Рекомендации по изучению

- Решай задачи последовательно: от `1` к `10`.
- После решения обязательно анализируй, почему тесты именно такие.
- Веди короткие заметки: идея, что было сложно, какие кейсы не учел.
- Через несколько дней повтори 1-2 задачи без подсказок.

## Чек-лист завершения задачи

- [ ] Код компилируется без ошибок
- [ ] Метод реализован в нужном файле задачи
- [ ] Тесты по задаче проходят
- [ ] Я могу объяснить решение вслух простыми словами