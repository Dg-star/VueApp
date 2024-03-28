<!--MainComponent.vue-->

<template>
    <div class="content">
        <div class="row">
            <div class="screen">
                <div class="square">
                    <h2 class="heading">Employees</h2>
                    <ul>
                        <li><router-link to="/employee-list">View employee list</router-link></li>
                        <li>Archive employees</li>
                        <li>Add new</li>
                    </ul>
                </div>
            </div>
            <div class="screen">
                <div class="square">
                    <h2 class="heading">Organizations</h2>
                    <ul>
                        <li>View organization list</li>
                        <li>Archive organizations</li>
                        <li>Add new</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="screen">
                <div class="square">
                    <h2 class="heading">Roles and Access Rights</h2>
                    <ul>
                        <li>View roles list</li>
                        <li>View access rights list</li>
                    </ul>
                </div>
            </div>
            <div class="screen">
                <div class="square">
                    <h2 class="heading">Group Operations</h2>
                    <ul>
                        <li>Archive organizations</li>
                        <li>Archive employees</li>
                        <li>Assign/Modify roles</li>
                        <li>Archive user accounts</li>
                        <li>Assign/Modify access rights</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'MainComponent',
    }
</script>

<style scoped>
    .content {
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
    }

    .row {
        display: flex;
        justify-content: center;
        align-items: center;
        margin-bottom: 20px;
    }

    .screen {
        flex: 1;
        margin: 10px;
    }

    .square {
        background-color: #f0f0f0;
        width: 300px;
        height: 250px;
        padding: 20px;
        border-radius: 10px;
        text-align: center;
    }

        .square h2.heading {
            font-size: 24px;
            margin-top: 0;
            margin-bottom: 15px;
        }

        .square ul {
            list-style-type: none;
            padding: 0;
            margin: 0;
        }

            .square ul li {
                margin-bottom: 10px;
            }
</style>
