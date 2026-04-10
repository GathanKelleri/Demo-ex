# Экзамен 09-02-07 4К

Проект содержит:
- SQL Server базу данных по нормализованной модели (3НФ);
- WPF-приложение на `.NET Framework 4.7.2`;
- подключение к БД через `ADO.NET Entity Data Model (EDMX)`.

## Состав проекта

- `database/01_create_db.sql` - создание структуры БД;
- `database/02_seed_data.sql` - заполнение данными и создание представлений;
- `normalization_3nf.md` - описание нормализации;
- `KafedraApp/KafedraApp.sln` - решение Visual Studio;
- `KafedraApp/KafedraApp/Data/Model1.edmx` - модель EDMX;
- `KafedraApp/KafedraApp/Data/DbReader.cs` - чтение данных через EDMX-контекст.
