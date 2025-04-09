-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 09, 2025 at 06:38 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `clinic`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `doctors`
--

CREATE TABLE `doctors` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `license_number` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `doctors_specializations`
--

CREATE TABLE `doctors_specializations` (
  `doctor_id` int(11) NOT NULL,
  `specialization_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `forgotten_users`
--

CREATE TABLE `forgotten_users` (
  `id` int(11) NOT NULL,
  `random_name` varchar(40) NOT NULL,
  `random_lastname` varchar(50) NOT NULL,
  `random_pesel` char(11) NOT NULL,
  `birth_date` date NOT NULL,
  `gender` tinyint(1) NOT NULL,
  `forget_date` datetime NOT NULL,
  `forgotten_by` int(11) DEFAULT NULL,
  `login` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `logs`
--

CREATE TABLE `logs` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `action` varchar(100) NOT NULL,
  `date` datetime NOT NULL,
  `details` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `patients`
--

CREATE TABLE `patients` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `pesel` char(11) NOT NULL,
  `birth_date` date NOT NULL,
  `gender` tinyint(1) NOT NULL,
  `country` varchar(50) NOT NULL,
  `city` varchar(50) NOT NULL,
  `postcode` varchar(10) NOT NULL,
  `street` varchar(20) NOT NULL,
  `house_number` int(10) UNSIGNED NOT NULL,
  `apartment_number` int(10) UNSIGNED DEFAULT NULL,
  `name` varchar(40) NOT NULL,
  `lastname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`id`, `user_id`, `pesel`, `birth_date`, `gender`, `country`, `city`, `postcode`, `street`, `house_number`, `apartment_number`, `name`, `lastname`) VALUES
(1, 2, '65041724445', '2025-03-26', 0, 'Poland', 'Gdańsk', '80-175', 'Leśna', 7, 0, 'Elżbieta', 'Krawczyk'),
(5, 6, '79112342973', '2025-04-01', 1, 'Poland', 'Poznań', '60-123', '', 45, 10, 'Michał', 'Nowak'),
(7, 8, '88061234567', '2100-01-20', 0, 'Poland', 'Wrocław', '50-301', 'Słoneczna', 18, 4, 'Anna', 'Adamczyk'),
(9, 10, '91072261389', '1991-07-22', 0, 'Poland', 'Warszawa', '00-125', 'Akacjowa', 8, 12, 'Agata', 'Lewandowska'),
(11, 12, '92111407829', '1992-11-14', 0, 'Poland', 'Lublin', '20-001', '', 7, 0, 'Aleksandra', 'Mazur');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `prescriptions`
--

CREATE TABLE `prescriptions` (
  `id` int(11) NOT NULL,
  `visit_id` int(11) NOT NULL,
  `medicine` varchar(100) NOT NULL,
  `dosage` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `restore_password`
--

CREATE TABLE `restore_password` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `code` int(11) NOT NULL,
  `expire` datetime NOT NULL,
  `use` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `sessions`
--

CREATE TABLE `sessions` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `session` varchar(255) NOT NULL,
  `expire` datetime NOT NULL,
  `method` enum('password','google') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `specializations`
--

CREATE TABLE `specializations` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `login` varchar(40) NOT NULL,
  `role` enum('patient','doctor','administrator') NOT NULL,
  `email` varchar(100) NOT NULL,
  `phonenumber` varchar(20) NOT NULL,
  `status` tinyint(1) DEFAULT NULL,
  `regdate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `login`, `role`, `email`, `phonenumber`, `status`, `regdate`) VALUES
(2, 'elzbieta.krawczyk1965', 'patient', 'elzbieta.kraw@zdrowie.pl', '503246789', 1, '2025-03-26 16:46:12'),
(5, 'anonim_00275594', '', 'anonim_d9abf2fe@example.com', '0002251633', NULL, '2025-03-31 23:59:25'),
(6, 'michal.nowak1979', 'patient', 'michal.nowak@zdrowie.pl', '504987321', 1, '2025-04-01 00:08:04'),
(7, '', 'patient', '', '', NULL, '2025-04-01 00:30:49'),
(8, 'anna.adamczyk1988', 'patient', 'anna.adam@zdrowie.pl', '505987654', 1, '2025-04-01 00:37:30'),
(9, 'iwud', 'patient', 'kscub@skcdjbu.pl', '503456789', 1, '2025-04-08 21:55:03'),
(10, 'agata.lewandowska91', 'patient', 'aga.lewa@zdrowie.pl', '509876321', 1, '2025-04-08 22:17:39'),
(12, 'aleksandra.wojcik92', 'patient', 'aleksandra.wojcik@zdrowie.pl', '504128768', 1, '2025-04-09 14:20:18'),
(13, 'anonim_310838b4', '', 'anonim_cb70ce92@example.com', '0006726907', NULL, '2025-04-09 14:57:16');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `visits`
--

CREATE TABLE `visits` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `diagnosis` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`id`),
  ADD KEY `doctors_ibfk_1` (`user_id`);

--
-- Indeksy dla tabeli `doctors_specializations`
--
ALTER TABLE `doctors_specializations`
  ADD KEY `specialization_id` (`specialization_id`),
  ADD KEY `doctor_id` (`doctor_id`);

--
-- Indeksy dla tabeli `forgotten_users`
--
ALTER TABLE `forgotten_users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `forgotten_by` (`forgotten_by`);

--
-- Indeksy dla tabeli `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`,`date`);

--
-- Indeksy dla tabeli `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `pesel` (`pesel`),
  ADD KEY `user_id` (`user_id`,`city`);

--
-- Indeksy dla tabeli `prescriptions`
--
ALTER TABLE `prescriptions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `visit_id` (`visit_id`);

--
-- Indeksy dla tabeli `restore_password`
--
ALTER TABLE `restore_password`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indeksy dla tabeli `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indeksy dla tabeli `specializations`
--
ALTER TABLE `specializations`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `login` (`login`),
  ADD UNIQUE KEY `email` (`email`,`phonenumber`),
  ADD UNIQUE KEY `phonenumber` (`phonenumber`);

--
-- Indeksy dla tabeli `visits`
--
ALTER TABLE `visits`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`),
  ADD KEY `doctor_id` (`doctor_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `forgotten_users`
--
ALTER TABLE `forgotten_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `prescriptions`
--
ALTER TABLE `prescriptions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `restore_password`
--
ALTER TABLE `restore_password`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sessions`
--
ALTER TABLE `sessions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `specializations`
--
ALTER TABLE `specializations`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `visits`
--
ALTER TABLE `visits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doctors`
--
ALTER TABLE `doctors`
  ADD CONSTRAINT `fk_doctors_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `doctors_specializations`
--
ALTER TABLE `doctors_specializations`
  ADD CONSTRAINT `fk_doc_spec_doctor` FOREIGN KEY (`doctor_id`) REFERENCES `doctors` (`id`),
  ADD CONSTRAINT `fk_doc_spec_specialization` FOREIGN KEY (`specialization_id`) REFERENCES `specializations` (`id`);

--
-- Constraints for table `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `fk_logs_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `patients`
--
ALTER TABLE `patients`
  ADD CONSTRAINT `fk_patients_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `prescriptions`
--
ALTER TABLE `prescriptions`
  ADD CONSTRAINT `fk_prescriptions_visits` FOREIGN KEY (`visit_id`) REFERENCES `visits` (`id`);

--
-- Constraints for table `restore_password`
--
ALTER TABLE `restore_password`
  ADD CONSTRAINT `fk_restore_password_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `sessions`
--
ALTER TABLE `sessions`
  ADD CONSTRAINT `fk_sessions_users` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `visits`
--
ALTER TABLE `visits`
  ADD CONSTRAINT `fk_visits_doctor` FOREIGN KEY (`doctor_id`) REFERENCES `doctors` (`id`),
  ADD CONSTRAINT `fk_visits_patient` FOREIGN KEY (`patient_id`) REFERENCES `patients` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
