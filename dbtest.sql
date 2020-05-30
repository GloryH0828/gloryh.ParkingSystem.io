/*
 Navicat Premium Data Transfer

 Source Server         : hgh
 Source Server Type    : MySQL
 Source Server Version : 80016
 Source Host           : localhost:3306
 Source Schema         : dbtest

 Target Server Type    : MySQL
 Target Server Version : 80016
 File Encoding         : 65001

 Date: 06/01/2020 13:51:09
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES (1, '123', '123');

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '自增主键',
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '姓名',
  `username` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '工号',
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '000' COMMENT '密码',
  `state` int(255) NULL DEFAULT 1 COMMENT '状态',
  `sex` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `age` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 8 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES (3, '王五', '12345', '000', 1, '女', 20);
INSERT INTO `employee` VALUES (5, '王朝', '1233', '000', 1, '男', 22);

-- ----------------------------
-- Table structure for parkcardinfo
-- ----------------------------
DROP TABLE IF EXISTS `parkcardinfo`;
CREATE TABLE `parkcardinfo`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '主键',
  `card_value` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '停车证号',
  `name` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '持证人姓名',
  `idcard` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '身份证号',
  `carnumber` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '车牌号',
  `state` int(11) NULL DEFAULT 0 COMMENT '标记。0=正常1=挂失',
  `sex` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of parkcardinfo
-- ----------------------------
INSERT INTO `parkcardinfo` VALUES (1, '1001', '黄光辉', '410225199808284110', '豫A00001', 0, '男');
INSERT INTO `parkcardinfo` VALUES (2, '1002', '张三', '41022019880909232X', '豫A00002', 0, '男');
INSERT INTO `parkcardinfo` VALUES (3, '1003', '李四', '410226196203022320', '豫A00003', 0, '女');
INSERT INTO `parkcardinfo` VALUES (4, '1004', '王五', '410236199806062323', '豫A00004', 0, '女');

-- ----------------------------
-- Table structure for parking
-- ----------------------------
DROP TABLE IF EXISTS `parking`;
CREATE TABLE `parking`  (
  `id` int(10) NOT NULL AUTO_INCREMENT COMMENT '主键',
  `parking_id` int(10) NOT NULL COMMENT '车位编号',
  `card_value` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '停车证号',
  `car_number` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '车牌号',
  `car_user` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '车主姓名',
  `state` int(255) NULL DEFAULT 0 COMMENT '状态；0=空闲，1=被使用',
  `begin_time` datetime(0) NULL DEFAULT NULL COMMENT '停入时间',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 8 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of parking
-- ----------------------------
INSERT INTO `parking` VALUES (1, 1, '1001', '豫A00001', '黄光辉', 1, '2020-01-05 10:57:59');
INSERT INTO `parking` VALUES (7, 5, '', '', '', 0, '2020-01-06 13:21:39');

-- ----------------------------
-- Table structure for parkmoney
-- ----------------------------
DROP TABLE IF EXISTS `parkmoney`;
CREATE TABLE `parkmoney`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '主键',
  `hour` int(255) NULL DEFAULT NULL COMMENT '每小时收费',
  `day` int(255) NULL DEFAULT NULL COMMENT '每天收费',
  `year` int(255) NULL DEFAULT NULL COMMENT '每年收费',
  `month` int(255) NULL DEFAULT NULL COMMENT '每月收费',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of parkmoney
-- ----------------------------
INSERT INTO `parkmoney` VALUES (1, 1, 21, 5210, 521);

SET FOREIGN_KEY_CHECKS = 1;
