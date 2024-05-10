Imports System.IO

Public Class FPS_Boost
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If english.Checked = True Then
            Dim yazilacakMetin As String = "english"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try

            developer_ibrahim_celik53.TabPage1.Text = "CPU Boost"
            developer_ibrahim_celik53.TabPage2.Text = "Automatic Shutdown"
            developer_ibrahim_celik53.TabPage3.Text = "Computer Info"
            developer_ibrahim_celik53.TabPage4.Text = "Advanced"
            '
            developer_ibrahim_celik53.yenile.Text = "Refresh"
            developer_ibrahim_celik53.Sec.Text = "Add Process"
            developer_ibrahim_celik53.letsstart.Text = "Start"
            developer_ibrahim_celik53.normalayar.Text = "Default Settings"
            developer_ibrahim_celik53.Label1.Text = "Boost Process"
            '
            developer_ibrahim_celik53.Label2.Text = "Hours"
            developer_ibrahim_celik53.Label3.Text = "Minutes"
            developer_ibrahim_celik53.Label4.Text = "Seconds"
            developer_ibrahim_celik53.Label5.Text = "Sign out"
            developer_ibrahim_celik53.Label6.Text = "Restart Computer"
            developer_ibrahim_celik53.Label7.Text = "Shutdown Computer"
            developer_ibrahim_celik53.Label8.Text = "Seconds"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Form Options"
            developer_ibrahim_celik53.Button1.Text = "Hide Me"
            developer_ibrahim_celik53.CheckBox2.Text = "Default"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Start"
            developer_ibrahim_celik53.GroupBox2.Text = "Time"
            developer_ibrahim_celik53.GroupBox3.Text = "Options"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Copy Text"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Cleaner (Junk Files)"
            developer_ibrahim_celik53.GroupBox6.Text = "Windows Startup"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Junk Files"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Junk Files"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Disable Startup"
            developer_ibrahim_celik53.CheckBox1.Text = "TopMost"
            developer_ibrahim_celik53.Button2.Text = "How to use Program"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Start"
            developer_ibrahim_celik53.LinkLabel1.Text = "My Steam Account"
            developer_ibrahim_celik53.LinkLabel2.Text = "Making the Software: İbrahim Çelik"

            '
            developer_ibrahim_celik53.timeribaslatma.Text = "Start"
            developer_ibrahim_celik53.timeridurdurma.Text = "Stop"

            Me.Hide()
        End If

        '

        If turkce.Checked = True Then
            Dim yazilacakMetin As String = "turkce"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "CPU Hız Aşırtma"
            developer_ibrahim_celik53.TabPage2.Text = "Otomatik Kapatma"
            developer_ibrahim_celik53.TabPage3.Text = "Bilgisayar Bilgisi"
            developer_ibrahim_celik53.TabPage4.Text = "Gelişmiş"
            developer_ibrahim_celik53.softwaredevic.Text = "Steam Oyunları"
            '
            developer_ibrahim_celik53.yenile.Text = "Yenile"
            developer_ibrahim_celik53.Sec.Text = "Programı Ekle"
            developer_ibrahim_celik53.letsstart.Text = "Başlat"
            developer_ibrahim_celik53.normalayar.Text = "Varsıyalan Ayarlar"
            developer_ibrahim_celik53.Label1.Text = "Hızlandıran Programlar"
            '
            developer_ibrahim_celik53.Label2.Text = "Saat"
            developer_ibrahim_celik53.Label3.Text = "Dakika"
            developer_ibrahim_celik53.Label4.Text = "Saniye"
            developer_ibrahim_celik53.Label5.Text = "Oturumu Kapat"
            developer_ibrahim_celik53.Label6.Text = "Yeniden Başlat"
            developer_ibrahim_celik53.Label7.Text = "Bilgisayarı Kapat"
            developer_ibrahim_celik53.Label8.Text = "Saniye"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Form Ayarları"
            developer_ibrahim_celik53.Button1.Text = "Gizle"
            developer_ibrahim_celik53.CheckBox2.Text = "Varsayılan"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Başlat"
            developer_ibrahim_celik53.GroupBox2.Text = "Zaman"
            developer_ibrahim_celik53.GroupBox3.Text = "Ayarlar"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Kopyala"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Temizleyici ( Önemsiz Dosyalar )"
            developer_ibrahim_celik53.GroupBox6.Text = "Windows Başlangıç"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Önemsiz Dosyalar"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Önemsiz Dosyalar"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Başlangıcı Devre Dışı Bırak"
            developer_ibrahim_celik53.CheckBox1.Text = "Üstte Kalma"
            developer_ibrahim_celik53.Button2.Text = "Programı nasıl kullanacağız?"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Başlat"
            developer_ibrahim_celik53.LinkLabel1.Text = "Steam Hesabım"
            developer_ibrahim_celik53.LinkLabel2.Text = "Yazılımı Yapan: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "Başlat"
            developer_ibrahim_celik53.timeridurdurma.Text = "Durdur"
            Me.Hide()
        End If

        If almanca.Checked = True Then
            Dim yazilacakMetin As String = "almanca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "CPU-Boost"
            developer_ibrahim_celik53.TabPage2.Text = "Automatische Abschaltung"
            developer_ibrahim_celik53.TabPage3.Text = "Computerinformationen"
            developer_ibrahim_celik53.TabPage4.Text = "Erweitert"
            developer_ibrahim_celik53.softwaredevic.Text = "Steam-Spiele"
            '
            developer_ibrahim_celik53.yenile.Text = "Aktualisieren"
            developer_ibrahim_celik53.Sec.Text = "Prozess hinzufügen"
            developer_ibrahim_celik53.letsstart.Text = "Start"
            developer_ibrahim_celik53.normalayar.Text = "Standardeinstellungen"
            developer_ibrahim_celik53.Label1.Text = "Boost-Prozess"
            '
            developer_ibrahim_celik53.Label2.Text = "Stunden"
            developer_ibrahim_celik53.Label3.Text = "Minuten"
            developer_ibrahim_celik53.Label4.Text = "Sekunden"
            developer_ibrahim_celik53.Label5.Text = "Abmelden"
            developer_ibrahim_celik53.Label6.Text = "Computer neu starten"
            developer_ibrahim_celik53.Label7.Text = "Computer herunterfahren"
            developer_ibrahim_celik53.Label8.Text = "Sekunden"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Formularoptionen"
            developer_ibrahim_celik53.Button1.Text = "Verstecke mich"
            developer_ibrahim_celik53.CheckBox2.Text = "Standard"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Start"
            developer_ibrahim_celik53.GroupBox2.Text = "Zeit"
            developer_ibrahim_celik53.GroupBox3.Text = "Optionen"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Text kopieren"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Cleaner (Junk-Dateien)"
            developer_ibrahim_celik53.GroupBox6.Text = "Windows-Start"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Junk-Dateien"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Junk-Dateien"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Start deaktivieren"
            developer_ibrahim_celik53.CheckBox1.Text = "Im Vordergrund"
            developer_ibrahim_celik53.Button2.Text = "Anleitung zur Verwendung des Programms"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Start"
            developer_ibrahim_celik53.LinkLabel1.Text = "Mein Steam-Konto"
            developer_ibrahim_celik53.LinkLabel2.Text = "Software erstellt von: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "Start"
            developer_ibrahim_celik53.timeridurdurma.Text = "Stop"

            Me.Hide()
        End If

        If french.Checked = True Then
            Dim yazilacakMetin As String = "french"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "Boost CPU"
            developer_ibrahim_celik53.TabPage2.Text = "Arrêt Automatique"
            developer_ibrahim_celik53.TabPage3.Text = "Informations sur l'ordinateur"
            developer_ibrahim_celik53.TabPage4.Text = "Avancé"
            developer_ibrahim_celik53.softwaredevic.Text = "Jeux Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Actualiser"
            developer_ibrahim_celik53.Sec.Text = "Ajouter un processus"
            developer_ibrahim_celik53.letsstart.Text = "Démarrer"
            developer_ibrahim_celik53.normalayar.Text = "Paramètres par défaut"
            developer_ibrahim_celik53.Label1.Text = "Processus Boost"
            '
            developer_ibrahim_celik53.Label2.Text = "Heures"
            developer_ibrahim_celik53.Label3.Text = "Minutes"
            developer_ibrahim_celik53.Label4.Text = "Secondes"
            developer_ibrahim_celik53.Label5.Text = "Se déconnecter"
            developer_ibrahim_celik53.Label6.Text = "Redémarrer l'ordinateur"
            developer_ibrahim_celik53.Label7.Text = "Éteindre l'ordinateur"
            developer_ibrahim_celik53.Label8.Text = "Secondes"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Options du formulaire"
            developer_ibrahim_celik53.Button1.Text = "Me cacher"
            developer_ibrahim_celik53.CheckBox2.Text = "Par défaut"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Démarrer"
            developer_ibrahim_celik53.GroupBox2.Text = "Temps"
            developer_ibrahim_celik53.GroupBox3.Text = "Options"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Copier le texte"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Nettoyeur (Fichiers indésirables)"
            developer_ibrahim_celik53.GroupBox6.Text = "Démarrage de Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Fichiers indésirables"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Fichiers indésirables"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Désactiver le démarrage"
            developer_ibrahim_celik53.CheckBox1.Text = "Au premier plan"
            developer_ibrahim_celik53.Button2.Text = "Comment utiliser le programme"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Démarrer"
            developer_ibrahim_celik53.LinkLabel1.Text = "Mon compte Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Création du logiciel : İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "commencer"
            developer_ibrahim_celik53.timeridurdurma.Text = "arrêt"
            Me.Hide()
        End If


        If italyanca.Checked = True Then
            Dim yazilacakMetin As String = "italyanca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "Boost CPU"
            developer_ibrahim_celik53.TabPage2.Text = "Spegnimento Automatico"
            developer_ibrahim_celik53.TabPage3.Text = "Informazioni del Computer"
            developer_ibrahim_celik53.TabPage4.Text = "Avanzate"
            developer_ibrahim_celik53.softwaredevic.Text = "Giochi Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Aggiorna"
            developer_ibrahim_celik53.Sec.Text = "Aggiungi Processo"
            developer_ibrahim_celik53.letsstart.Text = "Avvia"
            developer_ibrahim_celik53.normalayar.Text = "Impostazioni Predefinite"
            developer_ibrahim_celik53.Label1.Text = "Processo Boost"
            '
            developer_ibrahim_celik53.Label2.Text = "Ore"
            developer_ibrahim_celik53.Label3.Text = "Minuti"
            developer_ibrahim_celik53.Label4.Text = "Secondi"
            developer_ibrahim_celik53.Label5.Text = "Disconnetti"
            developer_ibrahim_celik53.Label6.Text = "Riavvia Computer"
            developer_ibrahim_celik53.Label7.Text = "Spegni Computer"
            developer_ibrahim_celik53.Label8.Text = "Secondi"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Opzioni Form"
            developer_ibrahim_celik53.Button1.Text = "Nascondimi"
            developer_ibrahim_celik53.CheckBox2.Text = "Predefinito"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Avvia"
            developer_ibrahim_celik53.GroupBox2.Text = "Tempo"
            developer_ibrahim_celik53.GroupBox3.Text = "Opzioni"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Copia Testo"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Pulizia (File Spazzatura)"
            developer_ibrahim_celik53.GroupBox6.Text = "Avvio di Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "File Spazzatura"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // File Spazzatura"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Disabilita Avvio"
            developer_ibrahim_celik53.CheckBox1.Text = "In Primo Piano"
            developer_ibrahim_celik53.Button2.Text = "Come Usare il Programma"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Avvia"
            developer_ibrahim_celik53.LinkLabel1.Text = "Il Mio Account Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Realizzazione del Software: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "inizio"
            developer_ibrahim_celik53.timeridurdurma.Text = "fermare"
            Me.Hide()
        End If


        If cince.Checked = True Then
            Dim yazilacakMetin As String = "cince"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try



            developer_ibrahim_celik53.TabPage1.Text = "CPU 提升"
            developer_ibrahim_celik53.TabPage2.Text = "自动关机"
            developer_ibrahim_celik53.TabPage3.Text = "电脑信息"
            developer_ibrahim_celik53.TabPage4.Text = "高级设置"
            developer_ibrahim_celik53.softwaredevic.Text = "Steam 游戏"
            '
            developer_ibrahim_celik53.yenile.Text = "刷新"
            developer_ibrahim_celik53.Sec.Text = "添加进程"
            developer_ibrahim_celik53.letsstart.Text = "开始"
            developer_ibrahim_celik53.normalayar.Text = "默认设置"
            developer_ibrahim_celik53.Label1.Text = "提升进程"
            '
            developer_ibrahim_celik53.Label2.Text = "小时"
            developer_ibrahim_celik53.Label3.Text = "分钟"
            developer_ibrahim_celik53.Label4.Text = "秒钟"
            developer_ibrahim_celik53.Label5.Text = "登出"
            developer_ibrahim_celik53.Label6.Text = "重启电脑"
            developer_ibrahim_celik53.Label7.Text = "关机电脑"
            developer_ibrahim_celik53.Label8.Text = "秒钟"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "表单选项"
            developer_ibrahim_celik53.Button1.Text = "隐藏"
            developer_ibrahim_celik53.CheckBox2.Text = "默认"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "开始"
            developer_ibrahim_celik53.GroupBox2.Text = "时间"
            developer_ibrahim_celik53.GroupBox3.Text = "选项"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "复制文本"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: 清理器 (垃圾文件)"
            developer_ibrahim_celik53.GroupBox6.Text = "Windows 启动"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "垃圾文件"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // 垃圾文件"
            developer_ibrahim_celik53.disableyapmastartup.Text = "禁用启动"
            developer_ibrahim_celik53.CheckBox1.Text = "置顶显示"
            developer_ibrahim_celik53.Button2.Text = "使用说明"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "开始"
            developer_ibrahim_celik53.LinkLabel1.Text = "我的 Steam 帐户"
            developer_ibrahim_celik53.LinkLabel2.Text = "软件制作：İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "開始"
            developer_ibrahim_celik53.timeridurdurma.Text = "停止"
            Me.Hide()
        End If

        If rusca.Checked = True Then
            Dim yazilacakMetin As String = "rusca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "Увеличение процессора"
            developer_ibrahim_celik53.TabPage2.Text = "Автоматическое выключение"
            developer_ibrahim_celik53.TabPage3.Text = "Информация о компьютере"
            developer_ibrahim_celik53.TabPage4.Text = "Дополнительно"
            developer_ibrahim_celik53.softwaredevic.Text = "Игры в Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Обновить"
            developer_ibrahim_celik53.Sec.Text = "Добавить процесс"
            developer_ibrahim_celik53.letsstart.Text = "Старт"
            developer_ibrahim_celik53.normalayar.Text = "По умолчанию"
            developer_ibrahim_celik53.Label1.Text = "Ускорение процесса"
            '
            developer_ibrahim_celik53.Label2.Text = "Часы"
            developer_ibrahim_celik53.Label3.Text = "Минуты"
            developer_ibrahim_celik53.Label4.Text = "Секунды"
            developer_ibrahim_celik53.Label5.Text = "Выйти"
            developer_ibrahim_celik53.Label6.Text = "Перезагрузить компьютер"
            developer_ibrahim_celik53.Label7.Text = "Выключить компьютер"
            developer_ibrahim_celik53.Label8.Text = "Секунды"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Параметры формы"
            developer_ibrahim_celik53.Button1.Text = "Скрыть"
            developer_ibrahim_celik53.CheckBox2.Text = "По умолчанию"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Старт"
            developer_ibrahim_celik53.GroupBox2.Text = "Время"
            developer_ibrahim_celik53.GroupBox3.Text = "Параметры"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Копировать текст"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Очистка (Системные файлы)"
            developer_ibrahim_celik53.GroupBox6.Text = "Загрузка Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Системные файлы"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Системные файлы"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Отключить загрузку"
            developer_ibrahim_celik53.CheckBox1.Text = "Поверх всех окон"
            developer_ibrahim_celik53.Button2.Text = "Как использовать программу"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Старт"
            developer_ibrahim_celik53.LinkLabel1.Text = "Мой аккаунт Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Разработано: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "Начинать"
            developer_ibrahim_celik53.timeridurdurma.Text = "останавливаться"
            Me.Hide()
        End If

        If portekizce.Checked = True Then
            Dim yazilacakMetin As String = "portekizce"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try



            developer_ibrahim_celik53.TabPage1.Text = "Aumentar CPU"
            developer_ibrahim_celik53.TabPage2.Text = "Desligamento Automático"
            developer_ibrahim_celik53.TabPage3.Text = "Informações do Computador"
            developer_ibrahim_celik53.TabPage4.Text = "Avançado"
            developer_ibrahim_celik53.softwaredevic.Text = "Jogos do Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Atualizar"
            developer_ibrahim_celik53.Sec.Text = "Adicionar Processo"
            developer_ibrahim_celik53.letsstart.Text = "Iniciar"
            developer_ibrahim_celik53.normalayar.Text = "Configurações Padrão"
            developer_ibrahim_celik53.Label1.Text = "Processo de Aumento"
            '
            developer_ibrahim_celik53.Label2.Text = "Horas"
            developer_ibrahim_celik53.Label3.Text = "Minutos"
            developer_ibrahim_celik53.Label4.Text = "Segundos"
            developer_ibrahim_celik53.Label5.Text = "Sair"
            developer_ibrahim_celik53.Label6.Text = "Reiniciar Computador"
            developer_ibrahim_celik53.Label7.Text = "Desligar Computador"
            developer_ibrahim_celik53.Label8.Text = "Segundos"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Opções do Formulário"
            developer_ibrahim_celik53.Button1.Text = "Ocultar"
            developer_ibrahim_celik53.CheckBox2.Text = "Padrão"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Iniciar"
            developer_ibrahim_celik53.GroupBox2.Text = "Tempo"
            developer_ibrahim_celik53.GroupBox3.Text = "Opções"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Copiar Texto"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Limpeza (Arquivos Inúteis)"
            developer_ibrahim_celik53.GroupBox6.Text = "Inicialização do Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Arquivos Inúteis"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Arquivos Inúteis"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Desativar Inicialização"
            developer_ibrahim_celik53.CheckBox1.Text = "No Topo"
            developer_ibrahim_celik53.Button2.Text = "Como Usar o Programa"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Iniciar"
            developer_ibrahim_celik53.LinkLabel1.Text = "Minha Conta Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Desenvolvido por: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "Começar"
            developer_ibrahim_celik53.timeridurdurma.Text = "parar"
            Me.Hide()
        End If

        If ispanyolca.Checked = True Then
            Dim yazilacakMetin As String = "ispanyolca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try



            developer_ibrahim_celik53.TabPage1.Text = "Aumentar CPU"
            developer_ibrahim_celik53.TabPage2.Text = "Apagado Automático"
            developer_ibrahim_celik53.TabPage3.Text = "Información del Computador"
            developer_ibrahim_celik53.TabPage4.Text = "Avanzado"
            developer_ibrahim_celik53.softwaredevic.Text = "Juegos de Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Actualizar"
            developer_ibrahim_celik53.Sec.Text = "Agregar Proceso"
            developer_ibrahim_celik53.letsstart.Text = "Iniciar"
            developer_ibrahim_celik53.normalayar.Text = "Configuración por Defecto"
            developer_ibrahim_celik53.Label1.Text = "Proceso de Aumento"
            '
            developer_ibrahim_celik53.Label2.Text = "Horas"
            developer_ibrahim_celik53.Label3.Text = "Minutos"
            developer_ibrahim_celik53.Label4.Text = "Segundos"
            developer_ibrahim_celik53.Label5.Text = "Cerrar Sesión"
            developer_ibrahim_celik53.Label6.Text = "Reiniciar Computadora"
            developer_ibrahim_celik53.Label7.Text = "Apagar Computadora"
            developer_ibrahim_celik53.Label8.Text = "Segundos"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Opciones del Formulario"
            developer_ibrahim_celik53.Button1.Text = "Ocultar"
            developer_ibrahim_celik53.CheckBox2.Text = "Predeterminado"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Iniciar"
            developer_ibrahim_celik53.GroupBox2.Text = "Tiempo"
            developer_ibrahim_celik53.GroupBox3.Text = "Opciones"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Copiar Texto"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Limpiador (Archivos Basura)"
            developer_ibrahim_celik53.GroupBox6.Text = "Inicio de Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Archivos Basura"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Archivos Basura"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Deshabilitar Inicio"
            developer_ibrahim_celik53.CheckBox1.Text = "En Primer Plano"
            developer_ibrahim_celik53.Button2.Text = "Cómo Usar el Programa"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Iniciar"
            developer_ibrahim_celik53.LinkLabel1.Text = "Mi Cuenta de Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Desarrollado por: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "comenzar"
            developer_ibrahim_celik53.timeridurdurma.Text = "detener"
            Me.Hide()
        End If


        If korece.Checked = True Then
            Dim yazilacakMetin As String = "korece"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "CPU 부스트"
            developer_ibrahim_celik53.TabPage2.Text = "자동 종료"
            developer_ibrahim_celik53.TabPage3.Text = "컴퓨터 정보"
            developer_ibrahim_celik53.TabPage4.Text = "고급 설정"
            developer_ibrahim_celik53.softwaredevic.Text = "스팀 게임"
            '
            developer_ibrahim_celik53.yenile.Text = "새로고침"
            developer_ibrahim_celik53.Sec.Text = "프로세스 추가"
            developer_ibrahim_celik53.letsstart.Text = "시작"
            developer_ibrahim_celik53.normalayar.Text = "기본 설정"
            developer_ibrahim_celik53.Label1.Text = "부스트 프로세스"
            '
            developer_ibrahim_celik53.Label2.Text = "시간"
            developer_ibrahim_celik53.Label3.Text = "분"
            developer_ibrahim_celik53.Label4.Text = "초"
            developer_ibrahim_celik53.Label5.Text = "로그아웃"
            developer_ibrahim_celik53.Label6.Text = "컴퓨터 재시작"
            developer_ibrahim_celik53.Label7.Text = "컴퓨터 종료"
            developer_ibrahim_celik53.Label8.Text = "초"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "양식 옵션"
            developer_ibrahim_celik53.Button1.Text = "숨기기"
            developer_ibrahim_celik53.CheckBox2.Text = "기본값"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "시작"
            developer_ibrahim_celik53.GroupBox2.Text = "시간"
            developer_ibrahim_celik53.GroupBox3.Text = "옵션"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "텍스트 복사"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: 클리너 (잔여 파일)"
            developer_ibrahim_celik53.GroupBox6.Text = "Windows 시작"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "잔여 파일"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // 잔여 파일"
            developer_ibrahim_celik53.disableyapmastartup.Text = "시작 프로그램 비활성화"
            developer_ibrahim_celik53.CheckBox1.Text = "맨 위에 유지"
            developer_ibrahim_celik53.Button2.Text = "프로그램 사용 방법"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "시작"
            developer_ibrahim_celik53.LinkLabel1.Text = "내 스팀 계정"
            developer_ibrahim_celik53.LinkLabel2.Text = "프로그램 제작자: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "시작"
            developer_ibrahim_celik53.timeridurdurma.Text = "멈추다"
            Me.Hide()
        End If

        If ukraynaca.Checked = True Then
            Dim yazilacakMetin As String = "ukraynaca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try



            developer_ibrahim_celik53.TabPage1.Text = "Підвищення CPU"
            developer_ibrahim_celik53.TabPage2.Text = "Автоматичне Вимкнення"
            developer_ibrahim_celik53.TabPage3.Text = "Інформація про Комп'ютер"
            developer_ibrahim_celik53.TabPage4.Text = "Додатково"
            developer_ibrahim_celik53.softwaredevic.Text = "Ігри у Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Оновити"
            developer_ibrahim_celik53.Sec.Text = "Додати Процес"
            developer_ibrahim_celik53.letsstart.Text = "Старт"
            developer_ibrahim_celik53.normalayar.Text = "Стандартні Налаштування"
            developer_ibrahim_celik53.Label1.Text = "Процес Підвищення"
            '
            developer_ibrahim_celik53.Label2.Text = "Години"
            developer_ibrahim_celik53.Label3.Text = "Хвилини"
            developer_ibrahim_celik53.Label4.Text = "Секунди"
            developer_ibrahim_celik53.Label5.Text = "Вийти"
            developer_ibrahim_celik53.Label6.Text = "Перезавантажити Комп'ютер"
            developer_ibrahim_celik53.Label7.Text = "Вимкнути Комп'ютер"
            developer_ibrahim_celik53.Label8.Text = "Секунди"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Параметри Форми"
            developer_ibrahim_celik53.Button1.Text = "Приховати"
            developer_ibrahim_celik53.CheckBox2.Text = "За Замовчуванням"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Старт"
            developer_ibrahim_celik53.GroupBox2.Text = "Час"
            developer_ibrahim_celik53.GroupBox3.Text = "Параметри"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Скопіювати Текст"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Очищення (Сміттєві Файли)"
            developer_ibrahim_celik53.GroupBox6.Text = "Старт Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Сміттєві Файли"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Сміттєві Файли"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Вимкнути Початок Роботи"
            developer_ibrahim_celik53.CheckBox1.Text = "На Першому Плані"
            developer_ibrahim_celik53.Button2.Text = "Як Користуватися Програмою"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Старт"
            developer_ibrahim_celik53.LinkLabel1.Text = "Мій Обліковий Запис Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Розробник: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "старт"
            developer_ibrahim_celik53.timeridurdurma.Text = "СТІЙ"
            Me.Hide()
        End If

        If yunanca.Checked = True Then
            Dim yazilacakMetin As String = "yunanca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try

            developer_ibrahim_celik53.TabPage1.Text = "Ενίσχυση CPU"
            developer_ibrahim_celik53.TabPage2.Text = "Αυτόματη Απενεργοποίηση"
            developer_ibrahim_celik53.TabPage3.Text = "Πληροφορίες Υπολογιστή"
            developer_ibrahim_celik53.TabPage4.Text = "Προηγμένες Ρυθμίσεις"
            developer_ibrahim_celik53.softwaredevic.Text = "Παιχνίδια Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Ανανέωση"
            developer_ibrahim_celik53.Sec.Text = "Προσθήκη Διεργασίας"
            developer_ibrahim_celik53.letsstart.Text = "Έναρξη"
            developer_ibrahim_celik53.normalayar.Text = "Προεπιλεγμένες Ρυθμίσεις"
            developer_ibrahim_celik53.Label1.Text = "Διεργασία Ενίσχυσης"
            '
            developer_ibrahim_celik53.Label2.Text = "Ώρες"
            developer_ibrahim_celik53.Label3.Text = "Λεπτά"
            developer_ibrahim_celik53.Label4.Text = "Δευτερόλεπτα"
            developer_ibrahim_celik53.Label5.Text = "Αποσύνδεση"
            developer_ibrahim_celik53.Label6.Text = "Επανεκκίνηση Υπολογιστή"
            developer_ibrahim_celik53.Label7.Text = "Απενεργοποίηση Υπολογιστή"
            developer_ibrahim_celik53.Label8.Text = "Δευτερόλεπτα"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Επιλογές Φόρμας"
            developer_ibrahim_celik53.Button1.Text = "Απόκρυψη"
            developer_ibrahim_celik53.CheckBox2.Text = "Προεπιλογή"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Έναρξη"
            developer_ibrahim_celik53.GroupBox2.Text = "Χρόνος"
            developer_ibrahim_celik53.GroupBox3.Text = "Επιλογές"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Αντιγραφή Κειμένου"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Καθαριστής (Αχρησιμοποίητα Αρχεία)"
            developer_ibrahim_celik53.GroupBox6.Text = "Εκκίνηση των Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Αχρησιμοποίητα Αρχεία"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Αχρησιμοποίητα Αρχεία"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Απενεργοποίηση Εκκίνησης"
            developer_ibrahim_celik53.CheckBox1.Text = "Πάνω απ' όλα"
            developer_ibrahim_celik53.Button2.Text = "Οδηγίες Χρήσης του Προγράμματος"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Έναρξη"
            developer_ibrahim_celik53.LinkLabel1.Text = "Ο λογαριασμός μου στο Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Ανάπτυξη από: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "Αρχή"
            developer_ibrahim_celik53.timeridurdurma.Text = "να σταματήσει"
            Me.Hide()
        End If

        If polanya.Checked = True Then
            Dim yazilacakMetin As String = "polanya"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try

            developer_ibrahim_celik53.TabPage1.Text = "Wzmocnienie CPU"
            developer_ibrahim_celik53.TabPage2.Text = "Automatyczne Wyłączanie"
            developer_ibrahim_celik53.TabPage3.Text = "Informacje o Komputerze"
            developer_ibrahim_celik53.TabPage4.Text = "Zaawansowane"
            developer_ibrahim_celik53.softwaredevic.Text = "Gry na Steam"
            '
            developer_ibrahim_celik53.yenile.Text = "Odśwież"
            developer_ibrahim_celik53.Sec.Text = "Dodaj Proces"
            developer_ibrahim_celik53.letsstart.Text = "Start"
            developer_ibrahim_celik53.normalayar.Text = "Domyślne Ustawienia"
            developer_ibrahim_celik53.Label1.Text = "Proces Wzmocnienia"
            '
            developer_ibrahim_celik53.Label2.Text = "Godziny"
            developer_ibrahim_celik53.Label3.Text = "Minuty"
            developer_ibrahim_celik53.Label4.Text = "Sekundy"
            developer_ibrahim_celik53.Label5.Text = "Wyloguj"
            developer_ibrahim_celik53.Label6.Text = "Restart Komputera"
            developer_ibrahim_celik53.Label7.Text = "Wyłącz Komputer"
            developer_ibrahim_celik53.Label8.Text = "Sekundy"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Opcje Formularza"
            developer_ibrahim_celik53.Button1.Text = "Ukryj"
            developer_ibrahim_celik53.CheckBox2.Text = "Domyślne"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Start"
            developer_ibrahim_celik53.GroupBox2.Text = "Czas"
            developer_ibrahim_celik53.GroupBox3.Text = "Opcje"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Kopiuj Tekst"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Czyszczenie (Pliki Śmieci)"
            developer_ibrahim_celik53.GroupBox6.Text = "Start Systemu Windows"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Pliki Śmieci"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Pliki Śmieci"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Wyłącz Start"
            developer_ibrahim_celik53.CheckBox1.Text = "Na wierzchu"
            developer_ibrahim_celik53.Button2.Text = "Jak używać Programu"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Start"
            developer_ibrahim_celik53.LinkLabel1.Text = "Mój Profil Steam"
            developer_ibrahim_celik53.LinkLabel2.Text = "Oprogramowanie stworzone przez: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "początek"
            developer_ibrahim_celik53.timeridurdurma.Text = "zatrzymywać się"
            Me.Hide()
        End If

        If arapca.Checked = True Then
            Dim yazilacakMetin As String = "arapca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "تعزيز وحدة المعالجة المركزية"
            developer_ibrahim_celik53.TabPage2.Text = "إيقاف تشغيل تلقائي"
            developer_ibrahim_celik53.TabPage3.Text = "معلومات الكمبيوتر"
            developer_ibrahim_celik53.TabPage4.Text = "متقدم"
            developer_ibrahim_celik53.softwaredevic.Text = "ألعاب ستيم"
            '
            developer_ibrahim_celik53.yenile.Text = "تحديث"
            developer_ibrahim_celik53.Sec.Text = "إضافة عملية"
            developer_ibrahim_celik53.letsstart.Text = "بدء"
            developer_ibrahim_celik53.normalayar.Text = "الإعدادات الافتراضية"
            developer_ibrahim_celik53.Label1.Text = "عملية التعزيز"
            '
            developer_ibrahim_celik53.Label2.Text = "ساعات"
            developer_ibrahim_celik53.Label3.Text = "دقائق"
            developer_ibrahim_celik53.Label4.Text = "ثواني"
            developer_ibrahim_celik53.Label5.Text = "تسجيل الخروج"
            developer_ibrahim_celik53.Label6.Text = "إعادة تشغيل الكمبيوتر"
            developer_ibrahim_celik53.Label7.Text = "إيقاف تشغيل الكمبيوتر"
            developer_ibrahim_celik53.Label8.Text = "ثواني"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "خيارات النموذج"
            developer_ibrahim_celik53.Button1.Text = "إخفاء"
            developer_ibrahim_celik53.CheckBox2.Text = "الافتراضي"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "بدء"
            developer_ibrahim_celik53.GroupBox2.Text = "الوقت"
            developer_ibrahim_celik53.GroupBox3.Text = "خيارات"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "نسخ النص"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "تنظيف C: (ملفات غير مرغوب فيها)"
            developer_ibrahim_celik53.GroupBox6.Text = "بدء تشغيل ويندوز"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "ملفات غير مرغوب فيها"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // ملفات غير مرغوب فيها"
            developer_ibrahim_celik53.disableyapmastartup.Text = "تعطيل بدء التشغيل"
            developer_ibrahim_celik53.CheckBox1.Text = "مُرَتَّبَ أعلى"
            developer_ibrahim_celik53.Button2.Text = "كيفية استخدام البرنامج"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "بدء"
            developer_ibrahim_celik53.LinkLabel1.Text = "حساب ستيم الخاص بي"
            developer_ibrahim_celik53.LinkLabel2.Text = "صنع البرنامج: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "يبدأ"
            developer_ibrahim_celik53.timeridurdurma.Text = "قف"
            Me.Hide()
        End If

        If macaristan.Checked = True Then
            Dim yazilacakMetin As String = "macaristan"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "CPU Fokozat"
            developer_ibrahim_celik53.TabPage2.Text = "Automatikus Kikapcsolás"
            developer_ibrahim_celik53.TabPage3.Text = "Számítógép Információ"
            developer_ibrahim_celik53.TabPage4.Text = "Speciális"
            developer_ibrahim_celik53.softwaredevic.Text = "Steam Játékok"
            '
            developer_ibrahim_celik53.yenile.Text = "Frissítés"
            developer_ibrahim_celik53.Sec.Text = "Folyamat Hozzáadása"
            developer_ibrahim_celik53.letsstart.Text = "Indítás"
            developer_ibrahim_celik53.normalayar.Text = "Alapértelmezett Beállítások"
            developer_ibrahim_celik53.Label1.Text = "Fokozat Folyamat"
            '
            developer_ibrahim_celik53.Label2.Text = "Óra"
            developer_ibrahim_celik53.Label3.Text = "Perc"
            developer_ibrahim_celik53.Label4.Text = "Másodperc"
            developer_ibrahim_celik53.Label5.Text = "Kijelentkezés"
            developer_ibrahim_celik53.Label6.Text = "Számítógép Újraindítás"
            developer_ibrahim_celik53.Label7.Text = "Számítógép Kikapcsolás"
            developer_ibrahim_celik53.Label8.Text = "Másodperc"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "Űrlap Beállítások"
            developer_ibrahim_celik53.Button1.Text = "Elrejtés"
            developer_ibrahim_celik53.CheckBox2.Text = "Alapértelmezett"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "Indítás"
            developer_ibrahim_celik53.GroupBox2.Text = "Idő"
            developer_ibrahim_celik53.GroupBox3.Text = "Opciók"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "Szöveg Másolása"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C: Tisztító (Felesleges Fájlok)"
            developer_ibrahim_celik53.GroupBox6.Text = "Windows Indítás"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "Felesleges Fájlok"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C: // Felesleges Fájlok"
            developer_ibrahim_celik53.disableyapmastartup.Text = "Indítás Letiltása"
            developer_ibrahim_celik53.CheckBox1.Text = "Legtetejére"
            developer_ibrahim_celik53.Button2.Text = "Program Használati Útmutató"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "Indítás"
            developer_ibrahim_celik53.LinkLabel1.Text = "Saját Steam Profil"
            developer_ibrahim_celik53.LinkLabel2.Text = "A Szoftver Készítője: İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "Rajt"
            developer_ibrahim_celik53.timeridurdurma.Text = "állj meg"
            Me.Hide()
        End If


        If japonca.Checked = True Then
            Dim yazilacakMetin As String = "japonca"
            Dim yeniDosyaAdi As String = "Languages.txt"
            Try
                Using sw As StreamWriter = New StreamWriter(yeniDosyaAdi)
                    sw.Write(yazilacakMetin)
                End Using
            Catch ex As Exception
            End Try


            developer_ibrahim_celik53.TabPage1.Text = "CPUブースト"
            developer_ibrahim_celik53.TabPage2.Text = "自動シャットダウン"
            developer_ibrahim_celik53.TabPage3.Text = "コンピュータ情報"
            developer_ibrahim_celik53.TabPage4.Text = "高度な設定"
            developer_ibrahim_celik53.softwaredevic.Text = "Steamゲーム"
            '
            developer_ibrahim_celik53.yenile.Text = "リフレッシュ"
            developer_ibrahim_celik53.Sec.Text = "プロセスの追加"
            developer_ibrahim_celik53.letsstart.Text = "スタート"
            developer_ibrahim_celik53.normalayar.Text = "デフォルト設定"
            developer_ibrahim_celik53.Label1.Text = "ブーストプロセス"
            '
            developer_ibrahim_celik53.Label2.Text = "時間（時）"
            developer_ibrahim_celik53.Label3.Text = "時間（分）"
            developer_ibrahim_celik53.Label4.Text = "秒"
            developer_ibrahim_celik53.Label5.Text = "ログアウト"
            developer_ibrahim_celik53.Label6.Text = "コンピュータの再起動"
            developer_ibrahim_celik53.Label7.Text = "コンピュータのシャットダウン"
            developer_ibrahim_celik53.Label8.Text = "秒"
            '
            developer_ibrahim_celik53.GroupBox4.Text = "フォームオプション"
            developer_ibrahim_celik53.Button1.Text = "非表示"
            developer_ibrahim_celik53.CheckBox2.Text = "デフォルト"
            '
            developer_ibrahim_celik53.otomatikkapatma.Text = "スタート"
            developer_ibrahim_celik53.GroupBox2.Text = "時間"
            developer_ibrahim_celik53.GroupBox3.Text = "オプション"
            '
            developer_ibrahim_celik53.yaziolarakalma.Text = "テキストのコピー"
            '
            developer_ibrahim_celik53.GroupBox5.Text = "C：クリーナー（不要なファイル）"
            developer_ibrahim_celik53.GroupBox6.Text = "Windowsのスタートアップ"
            '
            developer_ibrahim_celik53.junkfiles1.Text = "不要なファイル"
            developer_ibrahim_celik53.cdiskininjunk.Text = "C：// 不要なファイル"
            developer_ibrahim_celik53.disableyapmastartup.Text = "スタートアップを無効にする"
            developer_ibrahim_celik53.CheckBox1.Text = "最前面に表示"
            developer_ibrahim_celik53.Button2.Text = "プログラムの使用方法"
            '
            developer_ibrahim_celik53.oyunubaslatma.Text = "スタート"
            developer_ibrahim_celik53.LinkLabel1.Text = "私のSteamアカウント"
            developer_ibrahim_celik53.LinkLabel2.Text = "ソフトウェア製作者：İbrahim Çelik"

            developer_ibrahim_celik53.timeribaslatma.Text = "始める"
            developer_ibrahim_celik53.timeridurdurma.Text = "ストップ"
            Me.Hide()
        End If

    End Sub

    Private Sub FPS_Boost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class