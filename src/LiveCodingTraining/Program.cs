using LiveCodingTraining.TenBest;

Dictionary<int, (string Name, string Input, Func<string> Run)> demos = new()
{
    [1] = (
        "MoveZeroes",
        "arr = [1, 2, 0, 1, 0, 1, 0, 3, 0, 1]",
        () => FormatArray(LiveCodingPractice.MoveZeroes([1, 2, 0, 1, 0, 1, 0, 3, 0, 1]))
    ),
    [2] = (
        "TwoSum",
        "numbers = [2, 7, 11, 15], target = 9",
        () => FormatArray(LiveCodingPractice.TwoSum([2, 7, 11, 15], 9))
    ),
    [3] = (
        "FindEvenIndex",
        "arr = [1, 2, 3, 4, 3, 2, 1]",
        () => LiveCodingPractice.FindEvenIndex([1, 2, 3, 4, 3, 2, 1]).ToString()
    ),
    [4] = (
        "MergeIntervals",
        "intervals = [[1, 3], [2, 6], [8, 10], [15, 18]]",
        () => FormatMatrix(LiveCodingPractice.MergeIntervals([[1, 3], [2, 6], [8, 10], [15, 18]]))
    ),
    [5] = (
        "MySkipLast",
        "source = [1, 2, 3, 4, 5], count = 2",
        () => FormatArray(LiveCodingPractice.MySkipLast(new[] { 1, 2, 3, 4, 5 }, 2).ToArray())
    ),
    [6] = (
        "MyTakeLast",
        "source = [1, 2, 3, 4, 5], count = 3",
        () => FormatArray(LiveCodingPractice.MyTakeLast(new[] { 1, 2, 3, 4, 5 }, 3).ToArray())
    ),
    [7] = (
        "EvaluatePostfixExpression",
        "expression = \"2 1 + 3 *\"",
        () => LiveCodingPractice.EvaluatePostfixExpression("2 1 + 3 *").ToString()
    ),
    [8] = (
        "IsIsomorphic",
        "s = \"egg\", t = \"add\"",
        () => LiveCodingPractice.IsIsomorphic("egg", "add").ToString()
    ),
    [9] = (
        "RotateMatrix90Clockwise",
        "matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]",
        () =>
    {
        int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        LiveCodingPractice.RotateMatrix90Clockwise(matrix);
        return FormatMatrix(matrix);
    }),
    [10] = (
        "IsPerfectSquare",
        "num = 16",
        () => LiveCodingPractice.IsPerfectSquare(16).ToString()
    )
};

Console.WriteLine("Live Coding Training (10 задач)");
Console.WriteLine("Введите номер задачи (1-10), либо 0 для выхода.");

while (true)
{
    foreach ((int key, (string name, _, _)) in demos.OrderBy(pair => pair.Key))
    {
        Console.WriteLine($"{key}. {name}");
    }
    Console.Write("> ");

    string? raw = Console.ReadLine();
    if (!int.TryParse(raw, out int selected))
    {
        Console.WriteLine("Нужно ввести число.");
        continue;
    }

    if (selected == 0)
    {
        break;
    }

    if (!demos.TryGetValue(selected, out (string Name, string Input, Func<string> Run) demo))
    {
        Console.WriteLine("Неизвестный номер задачи.");
        continue;
    }

    try
    {
        Console.WriteLine($"Запуск задачи #{selected}: {demo.Name}");
        Console.WriteLine($"Вход: {demo.Input}");
        string output = demo.Run();
        Console.WriteLine($"Выход: {output}");
        Console.WriteLine("Статус: Успешно");
    }
    catch (NotImplementedException)
    {
        Console.WriteLine($"Запуск задачи #{selected}: {demo.Name}");
        Console.WriteLine($"Вход: {demo.Input}");
        Console.WriteLine("Статус: Не реализовано (NotImplementedException)");
        Console.WriteLine("Метод пока не реализован. Откройте соответствующий файл и напишите решение.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Запуск задачи #{selected}: {demo.Name}");
        Console.WriteLine($"Вход: {demo.Input}");
        Console.WriteLine($"Статус: Ошибка ({ex.GetType().Name})");
        Console.WriteLine($"Сообщение: {ex.Message}");
    }

    Console.WriteLine();
}

return;

static string FormatArray(int[] items) => $"[{string.Join(", ", items)}]";

static string FormatMatrix(int[][] matrix)
{
    return $"[{string.Join(", ", matrix.Select(FormatArray))}]";
}
