Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.SqlServer
Imports System.ArgumentException
Imports System.Reflection.RuntimeReflectionExtensions
Imports System.Management
Imports System.Drawing.Imaging
Imports Guna.UI2.WinForms
Imports System.Diagnostics.PerformanceCounter
Imports Microsoft.Win32
Imports System.Security.AccessControl
Imports System.ServiceProcess
Imports System.Threading.Tasks
Imports System.Reflection
Imports System.Security.Principal
Imports System.Media
Imports System.Windows.Forms
Public Class developer_ibrahim_celik53
    Const PROCESS_SET_QUOTA = &H100
    <DllImport("Kernel32.dll")>
    Public Shared Function OpenProcess(dwDesiredAccess As Int32, bInheritHandle As Boolean, dwProcessId As Int32) As IntPtr
    End Function
    <DllImport("Kernel32.dll")>
    Public Shared Function CloseHandle(hObject As IntPtr) As Boolean
    End Function
    <DllImport("Kernel32.dll")>
    Public Shared Function SetProcessWorkingSetSize(hProcess As IntPtr, dwMinimumWorkingSetSize As Int32, dwMaximumWorkingSetSize As Int32) As Boolean
    End Function

    'YouTube: @devibrahimcelik
    '
    Private isDragging As Boolean = False
    Private mouseOffset As Point
    '


    Private Declare Function GetProcessAffinityMask Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByRef lpProcessAffinityMask As IntPtr, ByRef lpSystemAffinityMask As IntPtr) As Boolean


    Declare Function SetProcessWorkingSetSize2 Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize2 As Integer, ByVal maximumWorkingSetSize2 As Integer) As Integer

    Private Declare Unicode Function GetShortPathName Lib "kernel32" Alias "GetShortPathNameW" (ByVal longPath As String, ByVal shortPath As Text.StringBuilder, ByVal shortPathLength As Integer) As Integer


    Private Declare Function GetCurrentProcess Lib "kernel32" () As Long
    Private Declare Function SetPriorityClass Lib "kernel32" (ByVal hProcess As Long, ByVal dwPriorityClass As PriorityClass) As Long
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long
    Const idle = 64
    Const below_normal = 16384
    Const normal = 32
    Const above_normal = 32768
    Const High_pri = 128
    Const real_time = 256


    Private Enum PriorityClass
        IDLE_PRIORITY_CLASS = &H40&
        BELOW_NORMAL_PRIORITY_CLASS = &H4000&
        NORMAL_PRIORITY_CLASS = &H20&
        ABOVE_NORMAL_PRIORITY_CLASS = &H8000&
        HIGH_PRIORITY_CLASS = &H80&
        REALTIME_PRIORITY_CLASS = &H100&
        PROCESS_MODE_BACKGROUND_BEGIN = &H100000
        PROCESS_MODE_BACKGROUND_END = &H200000
    End Enum
    '
    Dim player As New SoundPlayer()

    'Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk
    ''@softwaredevic
    'Bilerek sanal bellek koruması kullanmadım :)
    'YouTube: @devibrahimcelik


    Private Sub developer_ibrahim_celik53_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RadioButton7.Checked = True Then
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
        End If


        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            formukapatma.Visible = False
            miniyapma.Visible = False
        End If

        If Me.FormBorderStyle = FormBorderStyle.None Then
            formukapatma.Visible = True
            miniyapma.Visible = True
        End If



        '
        player.Stream = My.Resources.ibrahimcelik
        '
        '
        '
        '
        Dim dosyaAdi As String = "Languages.txt"
        Dim okunanDosya As String = ""
        Try
            Using sr As StreamReader = New StreamReader(dosyaAdi)
                okunanDosya = sr.ReadToEnd()
            End Using
        Catch ex As Exception
        End Try



        Label23.Text = okunanDosya
        '


        '

        '
        '
        '
        '@softwaredevic
        'Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk

        ListView1.View = View.Details ' 


        'sıralıyorum..
        Dim processes As Process() = Process.GetProcesses().OrderByDescending(Function(p) p.WorkingSet64).ToArray()


        For Each process As Process In processes

            Dim processName As String = process.ProcessName
            Dim processPath As String = ""

            Try
                processPath = process.MainModule.FileName
            Catch ex As Exception

            End Try
        Next

        ListView1.Columns.Add("Process", 150)
        ListView1.Columns.Add("RAM Spending (KB)", 120)
        ListView1.Columns.Add("İcon", 100)



        For Each process As Process In processes
            Dim processName As String = process.ProcessName
            Dim item As New ListViewItem(processName)
            item.SubItems.Add((process.WorkingSet64 / 1024).ToString()) '@developer_ibrahim_celik53
            item.ImageKey = processName
            ListView1.Items.Add(item)
        Next

        Dim coreCount2 As Integer = Environment.ProcessorCount
        cekirdeksayisi.Text = "CPU: " & coreCount2 & " Core"



        '
        'infolar

        Dim wmiScope As New ManagementScope("\root\cimv2")
        Dim wmiQuery As New ObjectQuery("SELECT * FROM Win32_Processor")
        Dim wmiSearcher As New ManagementObjectSearcher(wmiScope, wmiQuery)

        Dim wmiResults As ManagementObjectCollection = wmiSearcher.Get()

        If wmiResults.Count > 0 Then
            For Each wmiResult As ManagementObject In wmiResults
                Dim processorName As String = wmiResult("Name").ToString()
                Label17.Text = processorName
            Next
        Else
        End If


        Label18.Text = GetGraphicsCardName()
        Dim ramInfo As String = GetRAMInfo()
        Label19.Text = "RAM: " & ramInfo
        Label20.Text = GetDiskInfo()
        Label21.Text = GetMotherboardInfo()


        '
        Label22.Text = GetComputerName()



        '
        '

        steamlnkalma.PerformClick()
        '
        '

        'dil
        'dil
        '
        '
        '
        '
        'dil
        'sananehaf







        If Label23.Text = "turkce" Then
            TabPage1.Text = "CPU Hız Aşırtma"
            TabPage2.Text = "Otomatik Kapatma"
            TabPage3.Text = "Bilgisayar Bilgisi"
            TabPage4.Text = "Gelişmiş"
            softwaredevic.Text = "Steam Oyunları"
            '
            yenile.Text = "Yenile"
            Sec.Text = "Programı Ekle"
            letsstart.Text = "Başlat"
            normalayar.Text = "Varsıyalan Ayarlar"
            Label1.Text = "Hızlandıran Programlar"
            '
            Label2.Text = "Saat"
            Label3.Text = "Dakika"
            Label4.Text = "Saniye"
            Label5.Text = "Oturumu Kapat"
            Label6.Text = "Yeniden Başlat"
            Label7.Text = "Bilgisayarı Kapat"
            Label8.Text = "Saniye"
            '
            GroupBox4.Text = "Form Ayarları"
            Button1.Text = "Gizle"
            CheckBox2.Text = "Varsayılan"
            '
            otomatikkapatma.Text = "Başlat"
            GroupBox2.Text = "Zaman"
            GroupBox3.Text = "Ayarlar"
            '
            yaziolarakalma.Text = "Kopyala"
            '
            GroupBox5.Text = "C: Temizleyici ( Önemsiz Dosyalar )"
            GroupBox6.Text = "Windows Başlangıç"
            '
            junkfiles1.Text = "Önemsiz Dosyalar"
            cdiskininjunk.Text = "C: // Önemsiz Dosyalar"
            disableyapmastartup.Text = "Başlangıcı Devre Dışı Bırak"
            CheckBox1.Text = "Üstte Kalma"
            Button2.Text = "Programı nasıl kullanacağız"
            '
            oyunubaslatma.Text = "Başlat"
            LinkLabel1.Text = "Steam Hesabım"
            LinkLabel2.Text = "Yazılımı Yapan: İbrahim Çelik"
        End If


        If Label23.Text = "english" Then
            TabPage1.Text = "CPU Boost"
            TabPage2.Text = "Automatic Shutdown"
            TabPage3.Text = "Computer Info"
            TabPage4.Text = "Advanced"
            softwaredevic.Text = "Steam Games"
            '
            yenile.Text = "Refresh"
            Sec.Text = "Add Process"
            letsstart.Text = "Start"
            normalayar.Text = "Default Settings"
            Label1.Text = "Boost Process"
            '
            Label2.Text = "Hours"
            Label3.Text = "Minutes"
            Label4.Text = "Seconds"
            Label5.Text = "Sign out"
            Label6.Text = "Restart Computer"
            Label7.Text = "Shutdown Computer"
            Label8.Text = "Seconds"
            '
            GroupBox4.Text = "Form Options"
            Button1.Text = "Hide Me"
            CheckBox2.Text = "Default"
            '
            otomatikkapatma.Text = "Start"
            GroupBox2.Text = "Time"
            GroupBox3.Text = "Options"
            '
            yaziolarakalma.Text = "Copy Text"
            '
            GroupBox5.Text = "C: Cleaner (Junk Files)"
            GroupBox6.Text = "Windows Startup"
            '
            junkfiles1.Text = "Junk Files"
            cdiskininjunk.Text = "C: // Junk Files"
            disableyapmastartup.Text = "Disable Startup"
            CheckBox1.Text = "TopMost"
            Button2.Text = "How to use Program"
            '
            oyunubaslatma.Text = "Start"
            LinkLabel1.Text = "My Steam Account"
            LinkLabel2.Text = "Created by: İbrahim Çelik"
        End If

        If Label23.Text = "almanca" Then
            TabPage1.Text = "CPU-Boost"
            TabPage2.Text = "Automatische Abschaltung"
            TabPage3.Text = "Computerinformationen"
            TabPage4.Text = "Erweitert"
            softwaredevic.Text = "Steam-Spiele"
            '
            yenile.Text = "Aktualisieren"
            Sec.Text = "Prozess hinzufügen"
            letsstart.Text = "Start"
            normalayar.Text = "Standardeinstellungen"
            Label1.Text = "Boost-Prozess"
            '
            Label2.Text = "Stunden"
            Label3.Text = "Minuten"
            Label4.Text = "Sekunden"
            Label5.Text = "Abmelden"
            Label6.Text = "Computer neu starten"
            Label7.Text = "Computer herunterfahren"
            Label8.Text = "Sekunden"
            '
            GroupBox4.Text = "Formularoptionen"
            Button1.Text = "Verstecke mich"
            CheckBox2.Text = "Standard"
            '
            otomatikkapatma.Text = "Start"
            GroupBox2.Text = "Zeit"
            GroupBox3.Text = "Optionen"
            '
            yaziolarakalma.Text = "Text kopieren"
            '
            GroupBox5.Text = "C: Cleaner (Junk-Dateien)"
            GroupBox6.Text = "Windows-Start"
            '
            junkfiles1.Text = "Junk-Dateien"
            cdiskininjunk.Text = "C: // Junk-Dateien"
            disableyapmastartup.Text = "Start deaktivieren"
            CheckBox1.Text = "Im Vordergrund"
            Button2.Text = "Anleitung zur Verwendung des Programms"
            '
            oyunubaslatma.Text = "Start"
            LinkLabel1.Text = "Mein Steam-Konto"
            LinkLabel2.Text = "Software erstellt von: İbrahim Çelik"
        End If

        If Label23.Text = "french" Then
            TabPage1.Text = "Boost CPU"
            TabPage2.Text = "Arrêt Automatique"
            TabPage3.Text = "Informations sur l'ordinateur"
            TabPage4.Text = "Avancé"
            softwaredevic.Text = "Jeux Steam"
            '
            yenile.Text = "Actualiser"
            Sec.Text = "Ajouter un processus"
            letsstart.Text = "Démarrer"
            normalayar.Text = "Paramètres par défaut"
            Label1.Text = "Processus Boost"
            '
            Label2.Text = "Heures"
            Label3.Text = "Minutes"
            Label4.Text = "Secondes"
            Label5.Text = "Se déconnecter"
            Label6.Text = "Redémarrer l'ordinateur"
            Label7.Text = "Éteindre l'ordinateur"
            Label8.Text = "Secondes"
            '
            GroupBox4.Text = "Options du formulaire"
            Button1.Text = "Me cacher"
            CheckBox2.Text = "Par défaut"
            '
            otomatikkapatma.Text = "Démarrer"
            GroupBox2.Text = "Temps"
            GroupBox3.Text = "Options"
            '
            yaziolarakalma.Text = "Copier le texte"
            '
            GroupBox5.Text = "C: Nettoyeur (Fichiers indésirables)"
            GroupBox6.Text = "Démarrage de Windows"
            '
            junkfiles1.Text = "Fichiers indésirables"
            cdiskininjunk.Text = "C: // Fichiers indésirables"
            disableyapmastartup.Text = "Désactiver le démarrage"
            CheckBox1.Text = "Au premier plan"
            Button2.Text = "Comment utiliser le programme"
            '
            oyunubaslatma.Text = "Démarrer"
            LinkLabel1.Text = "Mon compte Steam"
            LinkLabel2.Text = "Création du logiciel : İbrahim Çelik"
        End If

        If Label23.Text = "italyanca" Then
            TabPage1.Text = "Boost CPU"
            TabPage2.Text = "Spegnimento Automatico"
            TabPage3.Text = "Informazioni del Computer"
            TabPage4.Text = "Avanzate"
            softwaredevic.Text = "Giochi Steam"
            '
            yenile.Text = "Aggiorna"
            Sec.Text = "Aggiungi Processo"
            letsstart.Text = "Avvia"
            normalayar.Text = "Impostazioni Predefinite"
            Label1.Text = "Processo Boost"
            '
            Label2.Text = "Ore"
            Label3.Text = "Minuti"
            Label4.Text = "Secondi"
            Label5.Text = "Disconnetti"
            Label6.Text = "Riavvia Computer"
            Label7.Text = "Spegni Computer"
            Label8.Text = "Secondi"
            '
            GroupBox4.Text = "Opzioni Form"
            Button1.Text = "Nascondimi"
            CheckBox2.Text = "Predefinito"
            '
            otomatikkapatma.Text = "Avvia"
            GroupBox2.Text = "Tempo"
            GroupBox3.Text = "Opzioni"
            '
            yaziolarakalma.Text = "Copia Testo"
            '
            GroupBox5.Text = "C: Pulizia (File Spazzatura)"
            GroupBox6.Text = "Avvio di Windows"
            '
            junkfiles1.Text = "File Spazzatura"
            cdiskininjunk.Text = "C: // File Spazzatura"
            disableyapmastartup.Text = "Disabilita Avvio"
            CheckBox1.Text = "In Primo Piano"
            Button2.Text = "Come Usare il Programma"
            '
            oyunubaslatma.Text = "Avvia"
            LinkLabel1.Text = "Il Mio Account Steam"
            LinkLabel2.Text = "Realizzazione del Software: İbrahim Çelik"
        End If


        If Label23.Text = "cince" Then
            TabPage1.Text = "CPU 提升"
            TabPage2.Text = "自动关机"
            TabPage3.Text = "电脑信息"
            TabPage4.Text = "高级设置"
            softwaredevic.Text = "Steam 游戏"
            '
            yenile.Text = "刷新"
            Sec.Text = "添加进程"
            letsstart.Text = "开始"
            normalayar.Text = "默认设置"
            Label1.Text = "提升进程"
            '
            Label2.Text = "小时"
            Label3.Text = "分钟"
            Label4.Text = "秒钟"
            Label5.Text = "登出"
            Label6.Text = "重启电脑"
            Label7.Text = "关机电脑"
            Label8.Text = "秒钟"
            '
            GroupBox4.Text = "表单选项"
            Button1.Text = "隐藏"
            CheckBox2.Text = "默认"
            '
            otomatikkapatma.Text = "开始"
            GroupBox2.Text = "时间"
            GroupBox3.Text = "选项"
            '
            yaziolarakalma.Text = "复制文本"
            '
            GroupBox5.Text = "C: 清理器 (垃圾文件)"
            GroupBox6.Text = "Windows 启动"
            '
            junkfiles1.Text = "垃圾文件"
            cdiskininjunk.Text = "C: // 垃圾文件"
            disableyapmastartup.Text = "禁用启动"
            CheckBox1.Text = "置顶显示"
            Button2.Text = "使用说明"
            '
            oyunubaslatma.Text = "开始"
            LinkLabel1.Text = "我的 Steam 帐户"
            LinkLabel2.Text = "软件制作：İbrahim Çelik"
        End If

        If Label23.Text = "rusca" Then
            TabPage1.Text = "Увеличение процессора"
            TabPage2.Text = "Автоматическое выключение"
            TabPage3.Text = "Информация о компьютере"
            TabPage4.Text = "Дополнительно"
            softwaredevic.Text = "Игры в Steam"
            '
            yenile.Text = "Обновить"
            Sec.Text = "Добавить процесс"
            letsstart.Text = "Старт"
            normalayar.Text = "По умолчанию"
            Label1.Text = "Ускорение процесса"
            '
            Label2.Text = "Часы"
            Label3.Text = "Минуты"
            Label4.Text = "Секунды"
            Label5.Text = "Выйти"
            Label6.Text = "Перезагрузить компьютер"
            Label7.Text = "Выключить компьютер"
            Label8.Text = "Секунды"
            '
            GroupBox4.Text = "Параметры формы"
            Button1.Text = "Скрыть"
            CheckBox2.Text = "По умолчанию"
            '
            otomatikkapatma.Text = "Старт"
            GroupBox2.Text = "Время"
            GroupBox3.Text = "Параметры"
            '
            yaziolarakalma.Text = "Копировать текст"
            '
            GroupBox5.Text = "C: Очистка (Системные файлы)"
            GroupBox6.Text = "Загрузка Windows"
            '
            junkfiles1.Text = "Системные файлы"
            cdiskininjunk.Text = "C: // Системные файлы"
            disableyapmastartup.Text = "Отключить загрузку"
            CheckBox1.Text = "Поверх всех окон"
            Button2.Text = "Как использовать программу"
            '
            oyunubaslatma.Text = "Старт"
            LinkLabel1.Text = "Мой аккаунт Steam"
            LinkLabel2.Text = "Разработано: İbrahim Çelik"
        End If

        If Label23.Text = "portekizce" Then
            TabPage1.Text = "Aumentar CPU"
            TabPage2.Text = "Desligamento Automático"
            TabPage3.Text = "Informações do Computador"
            TabPage4.Text = "Avançado"
            softwaredevic.Text = "Jogos do Steam"
            '
            yenile.Text = "Atualizar"
            Sec.Text = "Adicionar Processo"
            letsstart.Text = "Iniciar"
            normalayar.Text = "Configurações Padrão"
            Label1.Text = "Processo de Aumento"
            '
            Label2.Text = "Horas"
            Label3.Text = "Minutos"
            Label4.Text = "Segundos"
            Label5.Text = "Sair"
            Label6.Text = "Reiniciar Computador"
            Label7.Text = "Desligar Computador"
            Label8.Text = "Segundos"
            '
            GroupBox4.Text = "Opções do Formulário"
            Button1.Text = "Ocultar"
            CheckBox2.Text = "Padrão"
            '
            otomatikkapatma.Text = "Iniciar"
            GroupBox2.Text = "Tempo"
            GroupBox3.Text = "Opções"
            '
            yaziolarakalma.Text = "Copiar Texto"
            '
            GroupBox5.Text = "C: Limpeza (Arquivos Inúteis)"
            GroupBox6.Text = "Inicialização do Windows"
            '
            junkfiles1.Text = "Arquivos Inúteis"
            cdiskininjunk.Text = "C: // Arquivos Inúteis"
            disableyapmastartup.Text = "Desativar Inicialização"
            CheckBox1.Text = "No Topo"
            Button2.Text = "Como Usar o Programa"
            '
            oyunubaslatma.Text = "Iniciar"
            LinkLabel1.Text = "Minha Conta Steam"
            LinkLabel2.Text = "Desenvolvido por: İbrahim Çelik"
        End If

        If Label23.Text = "ispanyolca" Then
            TabPage1.Text = "Aumentar CPU"
            TabPage2.Text = "Apagado Automático"
            TabPage3.Text = "Información del Computador"
            TabPage4.Text = "Avanzado"
            softwaredevic.Text = "Juegos de Steam"
            '
            yenile.Text = "Actualizar"
            Sec.Text = "Agregar Proceso"
            letsstart.Text = "Iniciar"
            normalayar.Text = "Configuración por Defecto"
            Label1.Text = "Proceso de Aumento"
            '
            Label2.Text = "Horas"
            Label3.Text = "Minutos"
            Label4.Text = "Segundos"
            Label5.Text = "Cerrar Sesión"
            Label6.Text = "Reiniciar Computadora"
            Label7.Text = "Apagar Computadora"
            Label8.Text = "Segundos"
            '
            GroupBox4.Text = "Opciones del Formulario"
            Button1.Text = "Ocultar"
            CheckBox2.Text = "Predeterminado"
            '
            otomatikkapatma.Text = "Iniciar"
            GroupBox2.Text = "Tiempo"
            GroupBox3.Text = "Opciones"
            '
            yaziolarakalma.Text = "Copiar Texto"
            '
            GroupBox5.Text = "C: Limpiador (Archivos Basura)"
            GroupBox6.Text = "Inicio de Windows"
            '
            junkfiles1.Text = "Archivos Basura"
            cdiskininjunk.Text = "C: // Archivos Basura"
            disableyapmastartup.Text = "Deshabilitar Inicio"
            CheckBox1.Text = "En Primer Plano"
            Button2.Text = "Cómo Usar el Programa"
            '
            oyunubaslatma.Text = "Iniciar"
            LinkLabel1.Text = "Mi Cuenta de Steam"
            LinkLabel2.Text = "Desarrollado por: İbrahim Çelik"
        End If

        If Label23.Text = "korece" Then
            TabPage1.Text = "CPU 부스트"
            TabPage2.Text = "자동 종료"
            TabPage3.Text = "컴퓨터 정보"
            TabPage4.Text = "고급 설정"
            softwaredevic.Text = "스팀 게임"
            '
            yenile.Text = "새로고침"
            Sec.Text = "프로세스 추가"
            letsstart.Text = "시작"
            normalayar.Text = "기본 설정"
            Label1.Text = "부스트 프로세스"
            '
            Label2.Text = "시간"
            Label3.Text = "분"
            Label4.Text = "초"
            Label5.Text = "로그아웃"
            Label6.Text = "컴퓨터 재시작"
            Label7.Text = "컴퓨터 종료"
            Label8.Text = "초"
            '
            GroupBox4.Text = "양식 옵션"
            Button1.Text = "숨기기"
            CheckBox2.Text = "기본값"
            '
            otomatikkapatma.Text = "시작"
            GroupBox2.Text = "시간"
            GroupBox3.Text = "옵션"
            '
            yaziolarakalma.Text = "텍스트 복사"
            '
            GroupBox5.Text = "C: 클리너 (잔여 파일)"
            GroupBox6.Text = "Windows 시작"
            '
            junkfiles1.Text = "잔여 파일"
            cdiskininjunk.Text = "C: // 잔여 파일"
            disableyapmastartup.Text = "시작 프로그램 비활성화"
            CheckBox1.Text = "맨 위에 유지"
            Button2.Text = "프로그램 사용 방법"
            '
            oyunubaslatma.Text = "시작"
            LinkLabel1.Text = "내 스팀 계정"
            LinkLabel2.Text = "프로그램 제작자: İbrahim Çelik"
        End If

        If Label23.Text = "ukraynaca" Then
            TabPage1.Text = "Підвищення CPU"
            TabPage2.Text = "Автоматичне Вимкнення"
            TabPage3.Text = "Інформація про Комп'ютер"
            TabPage4.Text = "Додатково"
            softwaredevic.Text = "Ігри у Steam"
            '
            yenile.Text = "Оновити"
            Sec.Text = "Додати Процес"
            letsstart.Text = "Старт"
            normalayar.Text = "Стандартні Налаштування"
            Label1.Text = "Процес Підвищення"
            '
            Label2.Text = "Години"
            Label3.Text = "Хвилини"
            Label4.Text = "Секунди"
            Label5.Text = "Вийти"
            Label6.Text = "Перезавантажити Комп'ютер"
            Label7.Text = "Вимкнути Комп'ютер"
            Label8.Text = "Секунди"
            '
            GroupBox4.Text = "Параметри Форми"
            Button1.Text = "Приховати"
            CheckBox2.Text = "За Замовчуванням"
            '
            otomatikkapatma.Text = "Старт"
            GroupBox2.Text = "Час"
            GroupBox3.Text = "Параметри"
            '
            yaziolarakalma.Text = "Скопіювати Текст"
            '
            GroupBox5.Text = "C: Очищення (Сміттєві Файли)"
            GroupBox6.Text = "Старт Windows"
            '
            junkfiles1.Text = "Сміттєві Файли"
            cdiskininjunk.Text = "C: // Сміттєві Файли"
            disableyapmastartup.Text = "Вимкнути Початок Роботи"
            CheckBox1.Text = "На Першому Плані"
            Button2.Text = "Як Користуватися Програмою"
            '
            oyunubaslatma.Text = "Старт"
            LinkLabel1.Text = "Мій Обліковий Запис Steam"
            LinkLabel2.Text = "Розробник: İbrahim Çelik"
        End If

        If Label23.Text = "yunanca" Then
            TabPage1.Text = "Ενίσχυση CPU"
            TabPage2.Text = "Αυτόματη Απενεργοποίηση"
            TabPage3.Text = "Πληροφορίες Υπολογιστή"
            TabPage4.Text = "Προηγμένες Ρυθμίσεις"
            softwaredevic.Text = "Παιχνίδια Steam"
            '
            yenile.Text = "Ανανέωση"
            Sec.Text = "Προσθήκη Διεργασίας"
            letsstart.Text = "Έναρξη"
            normalayar.Text = "Προεπιλεγμένες Ρυθμίσεις"
            Label1.Text = "Διεργασία Ενίσχυσης"
            '
            Label2.Text = "Ώρες"
            Label3.Text = "Λεπτά"
            Label4.Text = "Δευτερόλεπτα"
            Label5.Text = "Αποσύνδεση"
            Label6.Text = "Επανεκκίνηση Υπολογιστή"
            Label7.Text = "Απενεργοποίηση Υπολογιστή"
            Label8.Text = "Δευτερόλεπτα"
            '
            GroupBox4.Text = "Επιλογές Φόρμας"
            Button1.Text = "Απόκρυψη"
            CheckBox2.Text = "Προεπιλογή"
            '
            otomatikkapatma.Text = "Έναρξη"
            GroupBox2.Text = "Χρόνος"
            GroupBox3.Text = "Επιλογές"
            '
            yaziolarakalma.Text = "Αντιγραφή Κειμένου"
            '
            GroupBox5.Text = "C: Καθαριστής (Αχρησιμοποίητα Αρχεία)"
            GroupBox6.Text = "Εκκίνηση των Windows"
            '
            junkfiles1.Text = "Αχρησιμοποίητα Αρχεία"
            cdiskininjunk.Text = "C: // Αχρησιμοποίητα Αρχεία"
            disableyapmastartup.Text = "Απενεργοποίηση Εκκίνησης"
            CheckBox1.Text = "Πάνω απ' όλα"
            Button2.Text = "Οδηγίες Χρήσης του Προγράμματος"
            '
            oyunubaslatma.Text = "Έναρξη"
            LinkLabel1.Text = "Ο λογαριασμός μου στο Steam"
            LinkLabel2.Text = "Ανάπτυξη από: İbrahim Çelik"
        End If

        If Label23.Text = "polanya" Then
            TabPage1.Text = "Wzmocnienie CPU"
            TabPage2.Text = "Automatyczne Wyłączanie"
            TabPage3.Text = "Informacje o Komputerze"
            TabPage4.Text = "Zaawansowane"
            softwaredevic.Text = "Gry na Steam"
            '
            yenile.Text = "Odśwież"
            Sec.Text = "Dodaj Proces"
            letsstart.Text = "Start"
            normalayar.Text = "Domyślne Ustawienia"
            Label1.Text = "Proces Wzmocnienia"
            '
            Label2.Text = "Godziny"
            Label3.Text = "Minuty"
            Label4.Text = "Sekundy"
            Label5.Text = "Wyloguj"
            Label6.Text = "Restart Komputera"
            Label7.Text = "Wyłącz Komputer"
            Label8.Text = "Sekundy"
            '
            GroupBox4.Text = "Opcje Formularza"
            Button1.Text = "Ukryj"
            CheckBox2.Text = "Domyślne"
            '
            otomatikkapatma.Text = "Start"
            GroupBox2.Text = "Czas"
            GroupBox3.Text = "Opcje"
            '
            yaziolarakalma.Text = "Kopiuj Tekst"
            '
            GroupBox5.Text = "C: Czyszczenie (Pliki Śmieci)"
            GroupBox6.Text = "Start Systemu Windows"
            '
            junkfiles1.Text = "Pliki Śmieci"
            cdiskininjunk.Text = "C: // Pliki Śmieci"
            disableyapmastartup.Text = "Wyłącz Start"
            CheckBox1.Text = "Na wierzchu"
            Button2.Text = "Jak używać Programu"
            '
            oyunubaslatma.Text = "Start"
            LinkLabel1.Text = "Mój Profil Steam"
            LinkLabel2.Text = "Oprogramowanie stworzone przez: İbrahim Çelik"
        End If

        If Label23.Text = "arapca" Then
            TabPage1.Text = "تعزيز وحدة المعالجة المركزية"
            TabPage2.Text = "إيقاف تشغيل تلقائي"
            TabPage3.Text = "معلومات الكمبيوتر"
            TabPage4.Text = "متقدم"
            softwaredevic.Text = "ألعاب ستيم"
            '
            yenile.Text = "تحديث"
            Sec.Text = "إضافة عملية"
            letsstart.Text = "بدء"
            normalayar.Text = "الإعدادات الافتراضية"
            Label1.Text = "عملية التعزيز"
            '
            Label2.Text = "ساعات"
            Label3.Text = "دقائق"
            Label4.Text = "ثواني"
            Label5.Text = "تسجيل الخروج"
            Label6.Text = "إعادة تشغيل الكمبيوتر"
            Label7.Text = "إيقاف تشغيل الكمبيوتر"
            Label8.Text = "ثواني"
            '
            GroupBox4.Text = "خيارات النموذج"
            Button1.Text = "إخفاء"
            CheckBox2.Text = "الافتراضي"
            '
            otomatikkapatma.Text = "بدء"
            GroupBox2.Text = "الوقت"
            GroupBox3.Text = "خيارات"
            '
            yaziolarakalma.Text = "نسخ النص"
            '
            GroupBox5.Text = "تنظيف C: (ملفات غير مرغوب فيها)"
            GroupBox6.Text = "بدء تشغيل ويندوز"
            '
            junkfiles1.Text = "ملفات غير مرغوب فيها"
            cdiskininjunk.Text = "C: // ملفات غير مرغوب فيها"
            disableyapmastartup.Text = "تعطيل بدء التشغيل"
            CheckBox1.Text = "مُرَتَّبَ أعلى"
            Button2.Text = "كيفية استخدام البرنامج"
            '
            oyunubaslatma.Text = "بدء"
            LinkLabel1.Text = "حساب ستيم الخاص بي"
            LinkLabel2.Text = "صنع البرنامج: İbrahim Çelik"
        End If

        If Label23.Text = "macaristan" Then
            TabPage1.Text = "CPU Fokozat"
            TabPage2.Text = "Automatikus Kikapcsolás"
            TabPage3.Text = "Számítógép Információ"
            TabPage4.Text = "Speciális"
            softwaredevic.Text = "Steam Játékok"
            '
            yenile.Text = "Frissítés"
            Sec.Text = "Folyamat Hozzáadása"
            letsstart.Text = "Indítás"
            normalayar.Text = "Alapértelmezett Beállítások"
            Label1.Text = "Fokozat Folyamat"
            '
            Label2.Text = "Óra"
            Label3.Text = "Perc"
            Label4.Text = "Másodperc"
            Label5.Text = "Kijelentkezés"
            Label6.Text = "Számítógép Újraindítás"
            Label7.Text = "Számítógép Kikapcsolás"
            Label8.Text = "Másodperc"
            '
            GroupBox4.Text = "Űrlap Beállítások"
            Button1.Text = "Elrejtés"
            CheckBox2.Text = "Alapértelmezett"
            '
            otomatikkapatma.Text = "Indítás"
            GroupBox2.Text = "Idő"
            GroupBox3.Text = "Opciók"
            '@developer_ibrahim_celik53
            yaziolarakalma.Text = "Szöveg Másolása"
            '
            GroupBox5.Text = "C: Tisztító (Felesleges Fájlok)"
            GroupBox6.Text = "Windows Indítás"
            '
            junkfiles1.Text = "Felesleges Fájlok"
            cdiskininjunk.Text = "C: // Felesleges Fájlok"
            disableyapmastartup.Text = "Indítás Letiltása"
            CheckBox1.Text = "Legtetejére"
            Button2.Text = "Program Használati Útmutató"
            '
            oyunubaslatma.Text = "Indítás"
            LinkLabel1.Text = "Saját Steam Profil"
            LinkLabel2.Text = "A Szoftver Készítője: İbrahim Çelik"
        End If


        If Label23.Text = "japonca" Then
            TabPage1.Text = "CPUブースト"
            TabPage2.Text = "自動シャットダウン"
            TabPage3.Text = "コンピュータ情報"
            TabPage4.Text = "高度な設定"
            softwaredevic.Text = "Steamゲーム"
            '
            yenile.Text = "リフレッシュ"
            Sec.Text = "プロセスの追加"
            letsstart.Text = "スタート"
            normalayar.Text = "デフォルト設定"
            Label1.Text = "ブーストプロセス"
            '
            Label2.Text = "時間（時）"
            Label3.Text = "時間（分）"
            Label4.Text = "秒"
            Label5.Text = "ログアウト"
            Label6.Text = "コンピュータの再起動"
            Label7.Text = "コンピュータのシャットダウン"
            Label8.Text = "秒"
            '
            GroupBox4.Text = "フォームオプション"
            Button1.Text = "非表示"
            CheckBox2.Text = "デフォルト"
            '
            otomatikkapatma.Text = "スタート"
            GroupBox2.Text = "時間"
            GroupBox3.Text = "オプション"
            '
            yaziolarakalma.Text = "テキストのコピー"
            '
            GroupBox5.Text = "C：クリーナー（不要なファイル）"
            GroupBox6.Text = "Windowsのスタートアップ"
            '
            junkfiles1.Text = "不要なファイル"
            cdiskininjunk.Text = "C：// 不要なファイル"
            disableyapmastartup.Text = "スタートアップを無効にする"
            CheckBox1.Text = "最前面に表示"
            Button2.Text = "プログラムの使用方法"
            '
            oyunubaslatma.Text = "スタート"
            LinkLabel1.Text = "私のSteamアカウント"
            LinkLabel2.Text = "ソフトウェア製作者：İbrahim Çelik"
        End If




        'dil
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim strComputer As String = "."
        Dim objWMIService As Object = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
        Dim colProcesses As Object = objWMIService.ExecQuery("Select * from Win32_Process")

        For Each objProcess In colProcesses
            objProcess.SetPriority(below_normal)
        Next
    End Sub

    Private Sub yenile_Click(sender As Object, e As EventArgs) Handles yenile.Click
        On Error Resume Next
        yenile.Text = "Wait.."

        ibrahimcelik.PerformClick()
    End Sub

    Private Sub Sec_Click(sender As Object, e As EventArgs) Handles Sec.Click
        If ListView1.SelectedItems.Count > 0 Then

            ListBox1.Items.Add(ListView1.SelectedItems(0).Text)

            letsstart.Enabled = True
        End If
    End Sub

    '@developer_ibrahim_celik53
    Private Sub otomatikkapatma_Click(sender As Object, e As EventArgs) Handles otomatikkapatma.Click
        On Error Resume Next
        If saath.Text = "" Then
            saath.Text = "0"
        End If

        If dakikam.Text = "" Then
            dakikam.Text = "0"
        End If

        If saniyes.Text = "" Then
            saniyes.Text = "0"
        End If



        '

        Label8.Text = Conversions.ToString(Conversions.ToDouble(Me.saath.Text) * 3600.0 + Conversions.ToDouble(Me.dakikam.Text) * 60.0 + Conversions.ToDouble(Me.saniyes.Text))
        kapatma.Start()
        PictureBox6.Enabled = True
        PictureBox6.Visible = True
        '



    End Sub

    Private Sub kapatma_Tick(sender As Object, e As EventArgs) Handles kapatma.Tick
        On Error Resume Next
        Label8.Text = Conversions.ToString(Conversions.ToDouble(Me.Label8.Text) - Conversions.ToString("1"))


        '

        If Label8.Text = 0 Then

            If oturumukapat.Checked = True Then
                Interaction.Shell("cmd /k shutdown -l")
                kapatma.Enabled = False
            End If


            If yenidenbaslat.Checked = True Then
                Interaction.Shell("cmd /k shutdown -r")
                kapatma.Enabled = False
            End If


            If zorlakapat.Checked = True Then
                Interaction.Shell("cmd /k shutdown -s -f")
                kapatma.Enabled = False
            End If








        End If



        If Label8.Text = "-1" Then
            Label8.Visible = False
            Label8.Text = "ibrahim_celik53"
            kapatma.Enabled = False
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561199096175384")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.instagram.com/softwaredevic/p/C2pOtE4MN10/")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        ' My.Computer.FileSystem.DeleteFile("%userprofile%\AppData\Local\Temp\",
        'Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        'Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)

    End Sub


    Private Sub normalayar_Click(sender As Object, e As EventArgs) Handles normalayar.Click

        normalayar.Text = "Wait to while complate"
        ListBox1.Items.Clear()
        ListBox1.Items.Add("explorer")
        Dim strComputer As String = "."
        Dim objWMIService As Object = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
        Dim colProcesses As Object = objWMIService.ExecQuery("Select * from Win32_Process")

        For Each objProcess In colProcesses
            objProcess.SetPriority(normal)
        Next


        '
        '
        '

        Dim processes As Process() = Process.GetProcesses()


        Dim affinityMask100 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr)

        For Each targetProcess As Process In processes
            Try
                ' Sadece .exe dosyalarını işle
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(".exe") Then

                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask100)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        '@developer_ibrahim_celik53

        ListBox1.Items.Clear()
        normalayar.Text = "Default Settings"

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Me.Close()
    End Sub

    Private Sub letsstart_Click(sender As Object, e As EventArgs) Handles letsstart.Click
        On Error Resume Next
        Dim cevap As MsgBoxResult
        cevap = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "FPS Booster")

        If cevap = MsgBoxResult.Yes Then

            letsstart.Text = "Wait to while complate"


            donuyor.AutoStart = True
            '@developer_ibrahim_celik53

            Dim itemsArray(ListBox1.Items.Count - 1) As Object
            ListBox1.Items.CopyTo(itemsArray, 0)

            Label9.Text = itemsArray(0).ToString()
            Label10.Text = itemsArray(1).ToString()
            Label11.Text = itemsArray(2).ToString()
            Label12.Text = itemsArray(3).ToString()
            Label13.Text = itemsArray(4).ToString()
            Label14.Text = itemsArray(5).ToString()
            Label15.Text = itemsArray(6).ToString()
            '
            Label24.Text = itemsArray(7).ToString()
            Label25.Text = itemsArray(8).ToString()
            Label26.Text = itemsArray(9).ToString()
            Label27.Text = itemsArray(10).ToString()
            Label28.Text = itemsArray(11).ToString()
            Label29.Text = itemsArray(12).ToString()
            Label30.Text = itemsArray(13).ToString()


            '



            Dim strComputer2 As String = "."
            Dim objWMIService2 As Object = GetObject("winmgmts:\\" & strComputer2 & "\root\cimv2")
            Dim colNotepadProcesses2 As Object = objWMIService2.ExecQuery("Select * from Win32_Process Where Name = '" & Label9.Text + ".exe" & "'")
            For Each objProcess2 In colNotepadProcesses2
                objProcess2.SetPriority(High_pri)
            Next

            Dim strComputer3 As String = "."
            Dim objWMIService3 As Object = GetObject("winmgmts:\\" & strComputer3 & "\root\cimv2")
            Dim colNotepadProcesses3 As Object = objWMIService3.ExecQuery("Select * from Win32_Process Where Name = '" & Label10.Text + ".exe" & "'")
            For Each objProcess3 In colNotepadProcesses3
                objProcess3.SetPriority(High_pri)
            Next

            Dim strComputer4 As String = "."
            Dim objWMIService4 As Object = GetObject("winmgmts:\\" & strComputer4 & "\root\cimv2")
            Dim colNotepadProcesses4 As Object = objWMIService4.ExecQuery("Select * from Win32_Process Where Name = '" & Label11.Text + ".exe" & "'")
            For Each objProcess4 In colNotepadProcesses4
                objProcess4.SetPriority(High_pri)
            Next

            Dim strComputer5 As String = "."
            Dim objWMIService5 As Object = GetObject("winmgmts:\\" & strComputer5 & "\root\cimv2")
            Dim colNotepadProcesses5 As Object = objWMIService5.ExecQuery("Select * from Win32_Process Where Name = '" & Label12.Text + ".exe" & "'")
            For Each objProcess5 In colNotepadProcesses5
                objProcess5.SetPriority(High_pri)
            Next

            Dim strComputer6 As String = "."
            Dim objWMIService6 As Object = GetObject("winmgmts:\\" & strComputer6 & "\root\cimv2")
            Dim colNotepadProcesses6 As Object = objWMIService6.ExecQuery("Select * from Win32_Process Where Name = '" & Label13.Text + ".exe" & "'")
            For Each objProcess6 In colNotepadProcesses6
                objProcess6.SetPriority(High_pri)
            Next

            Dim strComputer7 As String = "."
            Dim objWMIService7 As Object = GetObject("winmgmts:\\" & strComputer7 & "\root\cimv2")
            Dim colNotepadProcesses7 As Object = objWMIService7.ExecQuery("Select * from Win32_Process Where Name = '" & Label14.Text + ".exe" & "'")
            For Each objProcess7 In colNotepadProcesses7
                objProcess7.SetPriority(High_pri)
            Next

            Dim strComputer8 As String = "."
            Dim objWMIService8 As Object = GetObject("winmgmts:\\" & strComputer8 & "\root\cimv2")
            Dim colNotepadProcesses8 As Object = objWMIService8.ExecQuery("Select * from Win32_Process Where Name = '" & Label15.Text + ".exe" & "'")
            For Each objProcess8 In colNotepadProcesses8
                objProcess8.SetPriority(High_pri)
            Next
            '
            Dim strComputer9 As String = "."
            Dim objWMIService9 As Object = GetObject("winmgmts:\\" & strComputer9 & "\root\cimv2")
            Dim colNotepadProcesses9 As Object = objWMIService9.ExecQuery("Select * from Win32_Process Where Name = '" & Label24.Text + ".exe" & "'")
            For Each objProcess9 In colNotepadProcesses9
                objProcess9.SetPriority(High_pri)
            Next

            Dim strComputer10 As String = "."
            Dim objWMIService10 As Object = GetObject("winmgmts:\\" & strComputer10 & "\root\cimv2")
            Dim colNotepadProcesses10 As Object = objWMIService10.ExecQuery("Select * from Win32_Process Where Name = '" & Label25.Text + ".exe" & "'")
            For Each objProcess10 In colNotepadProcesses10
                objProcess10.SetPriority(High_pri)
            Next

            Dim strComputer11 As String = "."
            Dim objWMIService11 As Object = GetObject("winmgmts:\\" & strComputer11 & "\root\cimv2")
            Dim colNotepadProcesses11 As Object = objWMIService11.ExecQuery("Select * from Win32_Process Where Name = '" & Label26.Text + ".exe" & "'")
            For Each objProcess11 In colNotepadProcesses11
                objProcess11.SetPriority(High_pri)
            Next

            Dim strComputer12 As String = "."
            Dim objWMIService12 As Object = GetObject("winmgmts:\\" & strComputer12 & "\root\cimv2")
            Dim colNotepadProcesses12 As Object = objWMIService12.ExecQuery("Select * from Win32_Process Where Name = '" & Label27.Text + ".exe" & "'")
            For Each objProcess12 In colNotepadProcesses12
                objProcess12.SetPriority(High_pri)
            Next

            Dim strComputer13 As String = "."
            Dim objWMIService13 As Object = GetObject("winmgmts:\\" & strComputer13 & "\root\cimv2")
            Dim colNotepadProcesses13 As Object = objWMIService13.ExecQuery("Select * from Win32_Process Where Name = '" & Label28.Text + ".exe" & "'")
            For Each objProcess13 In colNotepadProcesses13
                objProcess13.SetPriority(High_pri)
            Next

            Dim strComputer14 As String = "."
            Dim objWMIService14 As Object = GetObject("winmgmts:\\" & strComputer14 & "\root\cimv2")
            Dim colNotepadProcesses14 As Object = objWMIService14.ExecQuery("Select * from Win32_Process Where Name = '" & Label29.Text + ".exe" & "'")
            For Each objProcess14 In colNotepadProcesses14
                objProcess14.SetPriority(High_pri)
            Next

            Dim strComputer15 As String = "."
            Dim objWMIService15 As Object = GetObject("winmgmts:\\" & strComputer15 & "\root\cimv2")
            Dim colNotepadProcesses15 As Object = objWMIService15.ExecQuery("Select * from Win32_Process Where Name = '" & Label30.Text + ".exe" & "'")
            For Each objProcess15 In colNotepadProcesses15
                objProcess15.SetPriority(High_pri)
            Next















            '
            '
            '

            Button5.PerformClick()

            Button4.PerformClick()

        Else
            MsgBox("Canceled")
        End If

        'DEVELOPED BY IBRAHIM CELIK   - YO 19


    End Sub

    <DllImport("kernel32.dll")>
    Public Shared Function SetProcessAffinityMask(ByVal hProcess As IntPtr, ByVal dwProcessAffinityMask As IntPtr) As IntPtr
    End Function


    '  Private Declare Function SetProcessAffinityMask2 Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwProcessAffinityMask As IntPtr) As Boolean

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim processes As Process() = Process.GetProcesses()

        Dim affinityMask As IntPtr = New IntPtr(1)


        For Each targetProcess As Process In processes
            Try

                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(".exe") Then

                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask)
                    If Not result Then

                    End If
                End If
            Catch ex As Exception

            End Try
        Next
        Threading.Thread.Sleep(1000)

        Button4.PerformClick()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim processes As Process() = Process.GetProcesses()


        Dim affinityMask97 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr) 'tüm çekirdekler
        For Each targetProcess As Process In processes
            Try
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(Label9.Text + ".exe") Then
                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask97)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        Dim affinityMask2 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr) 'tüm çekirdekler
        For Each targetProcess As Process In processes
            Try
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(Label10.Text + ".exe") Then
                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask2)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        Dim affinityMask3 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr) 'tüm çekirdekler
        For Each targetProcess As Process In processes
            Try
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(Label11.Text + ".exe") Then
                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask3)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        Dim affinityMask4 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr) 'tüm çekirdekler
        For Each targetProcess As Process In processes
            Try
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(Label12.Text + ".exe") Then
                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask4)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        Dim affinityMask5 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr) 'tüm çekirdekler
        For Each targetProcess As Process In processes
            Try
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(Label13.Text + ".exe") Then
                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask5)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        Dim affinityMask6 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr) 'tüm çekirdekler
        For Each targetProcess As Process In processes
            Try
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(Label14.Text + ".exe") Then
                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask6)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next


        Dim affinityMask67 As IntPtr = CType(2 ^ Environment.ProcessorCount - 1, IntPtr) 'tüm çekirdekler
        For Each targetProcess As Process In processes
            Try
                If Not String.IsNullOrEmpty(targetProcess.MainModule.FileName) AndAlso targetProcess.MainModule.FileName.ToLower().EndsWith(Label15.Text + ".exe") Then
                    Dim result As Boolean = SetProcessAffinityMask(targetProcess.Handle, affinityMask67)
                    If Not result Then
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        letsstart.Text = "Start Boost"
        MsgBox("Succesfull")


    End Sub


    Private Function GetGraphicsCardName() As String
        Dim wmiScope As New ManagementScope("\root\cimv2")
        Dim wmiQuery As New ObjectQuery("Select * FROM Win32_DisplayConfiguration")
        Dim wmiSearcher As New ManagementObjectSearcher(wmiScope, wmiQuery)

        Dim graphicsCardName As String = "Bilmiyom"

        Dim wmiResults As ManagementObjectCollection = wmiSearcher.Get()
        If wmiResults.Count > 0 Then
            For Each wmiResult As ManagementObject In wmiResults
                graphicsCardName = wmiResult("Description").ToString()
                Exit For
            Next
        End If
        Return graphicsCardName
    End Function

    Private Function GetRAMInfo() As String
        Dim wmiScope As New ManagementScope("\root\cimv2")


        Dim wmiQueryRAM As New ObjectQuery("Select * FROM Win32_PhysicalMemory")
        Dim wmiSearcherRAM As New ManagementObjectSearcher(wmiScope, wmiQueryRAM)

        Dim totalRAM As Double = 0.0
        Dim frequencies As New List(Of String)

        Dim wmiResultsRAM As ManagementObjectCollection = wmiSearcherRAM.Get()
        If wmiResultsRAM.Count > 0 Then
            For Each wmiResult As ManagementObject In wmiResultsRAM
                Dim capacityBytes As Long = Convert.ToInt64(wmiResult("Capacity"))
                Dim capacityGB As Double = capacityBytes / 1024 / 1024 / 1024 ' gb a çeviriyorum
                totalRAM += capacityGB

                Dim frequencyMhz As UInt32 = Convert.ToUInt32(wmiResult("Speed"))
                frequencies.Add(frequencyMhz.ToString() & " MHz")
            Next
        End If


        Dim frequencyInfo As String = String.Join(", ", frequencies)

        Dim ramInfo As String = String.Format("{0:F2} GB,  Frequency: {1}", totalRAM, frequencyInfo)
        Return ramInfo
    End Function

    Private Function GetDiskInfo() As String
        Dim wmiScope As New ManagementScope("\root\cimv2")
        Dim wmiQueryDiskDrive As New ObjectQuery("SELECT * FROM Win32_DiskDrive")
        Dim wmiSearcherDiskDrive As New ManagementObjectSearcher(wmiScope, wmiQueryDiskDrive)

        Dim diskInfo As String = ""

        Dim wmiResultsDiskDrive As ManagementObjectCollection = wmiSearcherDiskDrive.Get()
        If wmiResultsDiskDrive.Count > 0 Then
            For Each wmiResultDiskDrive As ManagementObject In wmiResultsDiskDrive
                Dim capacityBytes As Long = Convert.ToInt64(wmiResultDiskDrive("Size"))
                Dim capacityGB As Double = capacityBytes / 1024 / 1024 / 1024 ' Convert bytes to GB
                Dim model As String = wmiResultDiskDrive("Caption").ToString()

                If Not String.IsNullOrEmpty(model) Then

                    diskInfo &= model & " (" & String.Format("{0:F2} GB)", capacityGB) & vbCrLf


                    Dim deviceId As String = wmiResultDiskDrive("DeviceID").ToString()
                    Dim wmiQueryPartition As New ObjectQuery($"ASSOCIATORS OF {{Win32_DiskDrive.DeviceID='{deviceId}'}} WHERE AssocClass = Win32_DiskDriveToDiskPartition")
                    Dim wmiSearcherPartition As New ManagementObjectSearcher(wmiScope, wmiQueryPartition)

                    Dim wmiResultsPartition As ManagementObjectCollection = wmiSearcherPartition.Get()
                    If wmiResultsPartition.Count > 0 Then
                        For Each wmiResultPartition As ManagementObject In wmiResultsPartition
                            Dim partitionId As String = wmiResultPartition("DeviceID").ToString()
                            Dim wmiQueryLogicalDisk As New ObjectQuery($"ASSOCIATORS OF {{Win32_DiskPartition.DeviceID='{partitionId}'}} WHERE AssocClass = Win32_LogicalDiskToPartition")
                            Dim wmiSearcherLogicalDisk As New ManagementObjectSearcher(wmiScope, wmiQueryLogicalDisk)

                            Dim wmiResultsLogicalDisk As ManagementObjectCollection = wmiSearcherLogicalDisk.Get()
                            If wmiResultsLogicalDisk.Count > 0 Then
                                For Each wmiResultLogicalDisk As ManagementObject In wmiResultsLogicalDisk
                                    Dim driveLetter As String = wmiResultLogicalDisk("DeviceID").ToString()
                                    ' Disk'in sürücü harfini ekle
                                    diskInfo &= "  - " & driveLetter & vbCrLf
                                Next
                            End If
                        Next
                    End If
                End If
            Next
        Else
            diskInfo = "@developer_ibrahim_celik53"
        End If

        Return diskInfo
    End Function


    Private Function GetMotherboardInfo() As String
        Try
            Dim query As New SelectQuery("Win32_BaseBoard")
            Dim searcher As New ManagementObjectSearcher(query)
            Dim motherboardInfo As String = ""

            For Each obj As ManagementObject In searcher.Get()
                Dim manufacturer As String = obj("Manufacturer").ToString()
                Dim product As String = obj("Product").ToString()
                motherboardInfo = manufacturer & " " & product
                Exit For
            Next

            Return motherboardInfo
        Catch ex As Exception
            Return "@developer_ibrahim_celik53"
        End Try
    End Function




    Private Sub yaziolarakalma_Click(sender As Object, e As EventArgs) Handles yaziolarakalma.Click
        On Error Resume Next
        My.Computer.Clipboard.SetText("CPU" & vbCrLf & "- " + Label17.Text & vbCrLf & vbCrLf & vbCrLf & "GPU" & vbCrLf & "- " + Label18.Text & vbCrLf & vbCrLf & vbCrLf & "RAM" & vbCrLf & "- " + Label19.Text & vbCrLf & vbCrLf & vbCrLf & "Disk" & vbCrLf & "- " + Label20.Text & vbCrLf & vbCrLf & vbCrLf & "Motherboard" & vbCrLf & "- " + Label21.Text)
        MsgBox("Copied")
    End Sub

    Private Sub resimalma_Click(sender As Object, e As EventArgs) Handles resimalma.Click
        On Error Resume Next
        ibrahim_celik53.Text = (Guid.NewGuid.ToString() & Guid.NewGuid.ToString).Replace("-", "").Substring(0, 10).ToUpper
        resimalma.Visible = False
        yaziolarakalma.Visible = False
        RadioButton3.Visible = False

        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim screenshotPath As String = System.IO.Path.Combine(desktopPath, ibrahim_celik53.Text + ".png")

        Dim bmp As New Bitmap(Me.Width, Me.Height)
        TabPage3.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        bmp.Save(screenshotPath, ImageFormat.Png)



        MessageBox.Show("Screenshot is Saved to Desktop: " & screenshotPath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        resimalma.Visible = True
        yaziolarakalma.Visible = True
        RadioButton3.Visible = True
    End Sub


    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Me.Close()
    End Sub



    Function GetComputerName() As String
        Dim computerName As String = ""
        Try
            Dim query As String = "SELECT * FROM Win32_ComputerSystem"
            Dim scope As New ManagementScope("\\.\root\cimv2")
            Dim searcher As New ManagementObjectSearcher(scope, New ObjectQuery(query))
            Dim computerSystems As ManagementObjectCollection = searcher.Get()

            For Each computerSystem As ManagementObject In computerSystems
                computerName = computerSystem("Name").ToString()
            Next
        Catch ex As Exception
        End Try

        Return computerName
    End Function


    Function IsAdmin2() As Boolean
        Dim identity As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
        Dim principal As New System.Security.Principal.WindowsPrincipal(identity)
        Return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)
    End Function


    Function IsAdmin() As Boolean
        Dim identity As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
        Dim principal As New System.Security.Principal.WindowsPrincipal(identity)
        Return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)
    End Function


    Private Sub junkfiles1_Click(sender As Object, e As EventArgs) Handles junkfiles1.Click
        On Error Resume Next
        Interaction.Shell("cmd /k del /q/f/s %TEMP%\*")
        MsgBox("Delete All Files")
        Interaction.Shell("cmd /k start %userprofile%\AppData\Local\Temp")

    End Sub

    Private Sub cdiskininjunk_Click(sender As Object, e As EventArgs) Handles cdiskininjunk.Click
        On Error Resume Next
        MsgBox("Select All Checkbox, Click 'OKAY' for delete. Also you can cancel it")
        Interaction.Shell("cmd /k c:\windows\SYSTEM32\cleanmgr.exe /dC")
    End Sub

    Private Sub disableyapmastartup_Click(sender As Object, e As EventArgs) Handles disableyapmastartup.Click
        On Error Resume Next


        Dim eminmisin As MsgBoxResult
        eminmisin = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "FPS Booster")

        If eminmisin = MsgBoxResult.Yes Then
            DisableStartupPrograms()
        Else
            MsgBox("Canceled")
        End If

    End Sub


    Private Sub DisableStartupPrograms()
        On Error Resume Next
        Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

        If regKey IsNot Nothing Then
            Dim startupPrograms As String() = regKey.GetValueNames()

            For Each programName As String In startupPrograms

            Next

            regKey.Close()
        Else
        End If
    End Sub




    ''farkli
    Private Async Function StopServiceAsync(ByVal serviceName As String) As Task
        Dim serviceController As New ServiceController(serviceName)

        Try
            If serviceController.Status = ServiceControllerStatus.Running Then
                serviceController.Stop()
                Await Task.Run(Sub() serviceController.WaitForStatus(ServiceControllerStatus.Stopped))
            Else
            End If
        Catch ex As Exception
        End Try
    End Function
    '''


    Private Async Function StartServiceAsync(ByVal serviceName As String) As Task
        Dim serviceController As New ServiceController(serviceName)

        Try
            If serviceController.Status = ServiceControllerStatus.Stopped Then
                serviceController.Start()
                Await Task.Run(Sub() serviceController.WaitForStatus(ServiceControllerStatus.Running))
            Else
            End If
        Catch ex As Exception
        End Try
    End Function



    '
    '

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Me.Close()
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        Me.Close()
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub


    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        End If
        If CheckBox2.Checked = False Then
            Me.TopMost = False
        End If
    End Sub

    '
    '
    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabKontrol.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub TabControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles TabKontrol.MouseMove

        If Me.FormBorderStyle = FormBorderStyle.None Then
            If isDragging Then
                Dim mousePos = Control.MousePosition
                mousePos.Offset(mouseOffset.X, mouseOffset.Y)
                Me.Location = mousePos
            End If
        End If


    End Sub

    Private Sub TabControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles TabKontrol.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub dilsecenegi_Click(sender As Object, e As EventArgs) Handles dilsecenegi.Click
        FPS_Boost.Show()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim dosyaAdi As String = "How to Use.txt"
        Dim dosyaYolu As String = AppDomain.CurrentDomain.BaseDirectory & dosyaAdi

        If System.IO.File.Exists(dosyaYolu) Then
            Process.Start(dosyaYolu)
        Else
        End If

    End Sub


    Private Function GetTotalRAM() As Double
        ' çalmayın knklar created by ibrahim_celik53
        Dim query As New SelectQuery("Win32_ComputerSystem")
        Dim searcher As New ManagementObjectSearcher(query)
        Dim memory As Double = 0

        For Each info As ManagementObject In searcher.Get()
            memory = CDbl(info("TotalPhysicalMemory")) / (1024 * 1024)
        Next

        Return memory
    End Function

    Private Function GetRAMUsagePercentage() As Double

        Dim ramCounter As New PerformanceCounter("Memory", "Available MBytes")
        Dim availableRAM As Double = ramCounter.NextValue()

        Dim totalRAM As Double = GetTotalRAM()
        Dim ramUsagePercentage As Double = ((totalRAM - availableRAM) / totalRAM) * 100

        Return ramUsagePercentage
    End Function


    Private Sub sananeee_Tick(sender As Object, e As EventArgs) Handles sananeee.Tick
        Dim ramUsagePercentage As Double = GetRAMUsagePercentage()
        Label31.Text = "RAM Using: " & ramUsagePercentage.ToString("0.00") & "%"


        For Each instadeveloper_ibrahim_celik53 As Process In Process.GetProcesses
            Application.DoEvents()
            Dim j As IntPtr = OpenProcess(PROCESS_SET_QUOTA, False, instadeveloper_ibrahim_celik53.Id)
            If j <> 0 Then
                SetProcessWorkingSetSize(j, -1, -1)
                CloseHandle(j)
            End If
        Next
    End Sub



    'sananeee2

    Private Sub timeribaslatma_Click(sender As Object, e As EventArgs) Handles timeribaslatma.Click


        eskiramkullanimi.Visible = True
        Label31.Visible = True
        Dim ramUsagePercentage As Double = GetRAMUsagePercentage()
        eskiramkullanimi.Text = "RAM BEFORE: " & ramUsagePercentage.ToString("0.00") & "%"


        PictureBox9.Visible = False
        PictureBox8.Visible = True

        sananeee.Start()
    End Sub

    Private Sub timeridurdurma_Click(sender As Object, e As EventArgs) Handles timeridurdurma.Click
        eskiramkullanimi.Visible = False
        Label31.Visible = False
        PictureBox9.Visible = True
        PictureBox8.Visible = False
        sananeee.Stop()
    End Sub




    '

    '
    '



    Function IsSteamRunning() As Boolean
        Dim steamProcesses() As Process = Process.GetProcessesByName("Steam")
        Return steamProcesses.Length > 0
    End Function


    Private Sub developer_ibrahim_celik53_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    <DllImport("steam_api64.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SteamAPI_RestartAppIfNecessary(ByVal unOwnAppID As UInteger) As Boolean
    End Function


    Private Sub miniyapma_Click(sender As Object, e As EventArgs) Handles miniyapma.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub formukapatma_Click(sender As Object, e As EventArgs) Handles formukapatma.Click
        Me.Close()
    End Sub



    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabKontrol.SelectedIndexChanged
        player.Play()
    End Sub

    Private Sub oturumukapat_Click(sender As Object, e As EventArgs) Handles oturumukapat.Click
        If oturumukapat.Checked = True Then
            yenidenbaslat.Checked = False
            zorlakapat.Checked = False
        End If
    End Sub

    Private Sub yenidenbaslat_Click(sender As Object, e As EventArgs) Handles yenidenbaslat.Click
        If yenidenbaslat.Checked = True Then
            oturumukapat.Checked = False
            zorlakapat.Checked = False
        End If
    End Sub

    Private Sub zorlakapat_Click(sender As Object, e As EventArgs) Handles zorlakapat.Click
        If zorlakapat.Checked = True Then
            oturumukapat.Checked = False
            yenidenbaslat.Checked = False
        End If
    End Sub



    Private Sub ibrahimcelik_Click(sender As Object, e As EventArgs) Handles ibrahimcelik.Click
        ListView1.Clear()
        ListView1.View = View.Details ' 


        'sıralıyorum..
        Dim processes As Process() = Process.GetProcesses().OrderByDescending(Function(p) p.WorkingSet64).ToArray()


        For Each process As Process In processes

            Dim processName As String = process.ProcessName
            Dim processPath As String = ""

            Try
                processPath = process.MainModule.FileName
            Catch ex As Exception

            End Try
        Next

        ListView1.Columns.Add("Process", 150)
        ListView1.Columns.Add("RAM Spending (KB)", 120)
        ListView1.Columns.Add("İcon", 100)



        For Each process As Process In processes
            Dim processName As String = process.ProcessName
            Dim item As New ListViewItem(processName)
            item.SubItems.Add((process.WorkingSet64 / 1024).ToString()) '@ibrahim_celik53 Main acc
            item.ImageKey = processName
            ListView1.Items.Add(item)
        Next

        Dim coreCount2 As Integer = Environment.ProcessorCount
        cekirdeksayisi.Text = "CPU: " & coreCount2 & " Core"



        '
        'infolar

        Dim wmiScope As New ManagementScope("\root\cimv2")
        Dim wmiQuery As New ObjectQuery("SELECT * FROM Win32_Processor")
        Dim wmiSearcher As New ManagementObjectSearcher(wmiScope, wmiQuery)

        Dim wmiResults As ManagementObjectCollection = wmiSearcher.Get()

        If wmiResults.Count > 0 Then
            For Each wmiResult As ManagementObject In wmiResults
                Dim processorName As String = wmiResult("Name").ToString()
                Label17.Text = processorName
            Next
        Else
        End If
        yenile.Text = "Refresh"
    End Sub

    Private Sub RadioButton7_Click(sender As Object, e As EventArgs) Handles RadioButton7.Click
        If RadioButton7.Checked = True Then
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
        End If


        Me.FormBorderStyle = FormBorderStyle.Sizable

        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            formukapatma.Visible = False
            miniyapma.Visible = False
        End If

        If Me.FormBorderStyle = FormBorderStyle.None Then
            formukapatma.Visible = True
            miniyapma.Visible = True
        End If
    End Sub

    Private Sub RadioButton6_Click(sender As Object, e As EventArgs) Handles RadioButton6.Click
        If RadioButton6.Checked = True Then
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton4.Visible = True
        End If


        Me.FormBorderStyle = FormBorderStyle.None

        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            formukapatma.Visible = False
            miniyapma.Visible = False
        End If

        If Me.FormBorderStyle = FormBorderStyle.None Then
            formukapatma.Visible = True
            miniyapma.Visible = True
        End If

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561199096175384")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        System.Diagnostics.Process.Start("https://www.instagram.com/softwaredevic/p/C2pOtE4MN10/")
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/@devibrahimcelik")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        My.Computer.Clipboard.SetText("3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk")
        MsgBox("YOU COPIED IBRAHIM CELIK IS BITCOIN ADDRESS")
    End Sub

    Private Sub Instagrambtn_Click(sender As Object, e As EventArgs) Handles Instagrambtn.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/softwaredevic/p/C2pOtE4MN10/")
        MsgBox("Instagram : @softwaredevic")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/@devibrahimcelik")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        System.Diagnostics.Process.Start("https://github.com/SoftwareDEVibrahimcelik")
    End Sub
    'YouTube: @devibrahimcelik



    'YouTube: @devibrahimcelik


    'YouTube: @devibrahimcelik

    'Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk
    'YouTube: @devibrahimcelik
End Class





