После скачивания проекта выполните следующие шаги для его запуска:

Откройте проект: Дважды щелкните на файл WebApplicationVerstaTest.sln, при условии, что у вас установлены Visual Studio и пакет ASP.NET.
Настройте режим отладки:В Visual Studio убедитесь, что выбран режим Debug и используется протокол HTTPS. Если выбран другой протокол, измените его.
Запустите проект: Если появится ошибка, согласитесь с предложением запустить приложение, несмотря на это.

Если после запуска приложение не открывается, выполните следующие действия:
Щелкните правой кнопкой мыши на проекте WebApplicationVerstaTest в обозревателе решений.
Выберите Управление пакетами NuGet.
Перейдите на вкладку Обзор и введите Microsoft.EntityFrameworkCore, затем установите его.
Повторите процесс для Microsoft.EntityFrameworkCore.SqlServer и Microsoft.EntityFrameworkCore.Tools.
После установки всех пакетов повторно запустите проект.
