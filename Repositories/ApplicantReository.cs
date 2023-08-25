using HR_Help.Models;

namespace HR_Help.Repositories
{
    public class ApplicantReository
    {
        public static List<Applicant> Applicants = new()
        {
            new()
            {
                id = 1,
                firstName = "Иванов",
                lastName = "Иван",
                workExperience = 1,
                emailAddress = "ivanobv.ivan@email.com",
                phoneNumber = "88005553535",
                description = "Иванов Иван Иванович. " +
                "10 лет работал системным администратором в Ростелеком. " +
                "Прошел курс GeekBrains - фронт-энд разработчик. Знает TypeScript, фреймворки к нему, html и css."

            },
            new()
            {
                id = 2,
                firstName = "Петров",
                lastName = "Пётр",
                workExperience = 3,
                emailAddress = "petrov.petr@email.com",
                phoneNumber = "88005553535",
                description = "Петров Пётр Петрович. " +
                "3 года работал фрилансером. " +
                "Знает всё о 1С Битрикс и wordpress. Имеет в портфолио сайты на JavaScript + python."
            },
            new()
            {
                id = 3,
                firstName = "Дмитрий",
                lastName = "Кубышкин",
                workExperience = 0,
                emailAddress = "kubishkin@email.com",
                phoneNumber = "88005553535",
                description = "Кубышкин Дмитрий Дмитриевич. " +
                "Учился на системной инженерии. " +
                "Участвовал в разработке инди игры на Unity. Отвечал за написание всех скриптов на C#"
            },
            new()
            {
                id = 4,
                firstName = "Кристина",
                lastName = "Петрушина",
                workExperience = 1,
                emailAddress = "petrushina@email.com",
                phoneNumber = "88005553535",
                description = "Петрушина Кристина Алексеевна. " +
                "Училась в РТУ МИРЭА на направлении программная инженерия, на кафедре корпоративных систем. " +
                "Посмотрела курс с канала ExtreamCode и подумала что всё умеет и всё может," +
                " после чего пошла учить книгу Гербертa Шилдтa - C# 4.0: полное руководство," +
                " но это окалазось слишком сложно, и она начала смотреть видеоуроки от индусов с ютуба." +
                " далее, получив самые необходимые умения, она устраивается главным разработчиком сайта магазина косметики," +
                " где она взяла на себя весь бэк, делигировав фронт-энд чату GPT. Поддерживала созданный сайт около 9 месяцев," +
                " после чего, хозяйкой магазина было принято решение весь штат разработчиков (из 1 человека) - сократить," +
                " а после и закрыть магазин вовсе. Соискатель имеет навыки в ASP.NET, EF, JWT, LINQ, MS SQL," +
                " так же умеет работать с указателями с++, знает синтаксис java, php м python"
            },
            new()
            {
                id = 5,
                firstName = "Виктория",
                lastName = "Соколова",
                workExperience = 0,
                emailAddress = "sokolova@email.com",
                phoneNumber = "88005553535",
                description = "Виктория Сергеевна Соколова. " +
                "Прошла курс от SkillBox - Data Scientist "
            },
        };
    }
}
