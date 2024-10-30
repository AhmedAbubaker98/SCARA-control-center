
# SCARA Robotic Arm Control Interface

![Screenshot 2024-10-30 124641](https://github.com/user-attachments/assets/e0a76121-fe20-48cc-9712-771b02762dbc)

## Overview

This repository contains the complete codebase for the SCARA Robotic Arm Project, developed as part of a university project. The arm features a 5-DOF (Degrees of Freedom) design, optimized for precision and versatility in automated tasks. The project integrates an advanced user interface with computer vision capabilities, enabling real-time monitoring and control. It is equipped with both direct and inverse kinematics algorithms, live position tracking, and an automated tool station.

## Features

- **Integrated Computer Vision**: The control interface incorporates computer vision for object recognition and workspace analysis, enabling the SCARA arm to dynamically adjust based on real-time visual feedback.
  
- **Direct and Inverse Kinematics**: Both kinematic solutions allow precise position control of the arm. Direct kinematics enable quick position mapping from joint angles, while inverse kinematics compute required joint configurations for targeted end-effector positions.

- **Live Position Monitoring**: The interface provides continuous real-time updates on the end-effector's position, allowing precise manipulation and monitoring during operations.

- **Automated Tool Station**: An integrated automated tool station allows the arm to change tools or adjust configurations autonomously as per the task requirements.



## Code Structure

- **control_algorithms/**: Contains the core direct and inverse kinematics algorithms.
- **vision_module/**: Manages all computer vision processes and object detection.
- **ui_components/**: Components for building and managing the user interface.
- **tool_station/**: Code for the automated tool station, including task scheduling.

## Usage

1. **Initialize the SCARA Arm**: Power on the arm and connect to the control interface via a serial USB connection.
2. **Select Mode**: Choose between manual control, automated tasks, or vision-guided operation.
3. **Real-time Adjustments**: Use the live position monitor to track and adjust the end-effector's movements.
4. **Tool Changes**: For specific tasks, use the tool station controls within the UI to initiate tool changes.
